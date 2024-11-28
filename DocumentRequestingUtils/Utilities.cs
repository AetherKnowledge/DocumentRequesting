using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequestingUtils.Data;
using MaterialSkin.Controls;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.Office.Interop.Word;
using Xceed.Words.NET;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using DocumentFormat.OpenXml.Packaging;
using NPOI.SS.Formula.Functions;
using OpenXmlPowerTools;
using System.IO.Packaging;
using System.Xml.Linq;
using System.Drawing.Imaging;
using DinkToPdf;
using System.Net.Mail;
using System.Net;
using DocumentRequestingUtils.CustomControls;

namespace DocumentRequesting
{
    public sealed class Utilities
    {
        internal static readonly string DBString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";

        static Utilities()
        {
            if (File.Exists("..\\..\\..\\..\\Database.accdb"))
            {
                File.Copy("..\\..\\..\\..\\Database.accdb","Database.accdb",true);
            }
        }

        private static bool changeP1 = true;
        private static MaterialForm? _p1 = null;
        private static MaterialForm? _p2 = null;
        public static MaterialForm? PreviousPanel
        {
            get
            {
                return changeP1 ? _p1 : _p2;
            }
            set
            {
                if (value == (changeP1 ? _p2 : _p1)) return;

                if (changeP1) _p1 = value;
                else _p2 = value;

                changeP1 = !changeP1;
            }
        }
        public static MaterialForm? mainPanel = null;

        private static MaterialForm? adminPanel = null;
        public static MaterialForm? AdminPanel
        {
            get => adminPanel;
            set
            {
                if (User.CurrentUser != null && User.CurrentUser.Role == UserType.Admin) adminPanel = value;
            }
        }

        //public static readonly string DateTimeFormat = "MM/dd/yyyy hh:mm:ss tt";
        public static readonly string DateFormat = "MM/dd/yyyy";
        public static readonly string TimeFormat = "hh:mm:ss tt";

        public static System.Drawing.Point location = new System.Drawing.Point(0, 0);
        public static Size size = new Size(1280, 720);
        public static FormWindowState windowState = FormWindowState.Normal;
        public static void InitializeTextBoxWithPlaceholder(TextBox textBox)
        {
            string placeholder = textBox.Text;
            textBox.ForeColor = Color.Gray;
            DateTime.Now.ToString("MM dd yyyy mm:hh");
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

        }

        public static void ChangeButtonColors(Button button)
        {
            //normal
            button.MouseLeave += (sender, e) => { button.BackColor = Color.FromArgb(52, 63, 82); };
            button.MouseUp += (sender, e) => { button.BackColor = Color.FromArgb(52, 63, 82); };

            //hover
            button.MouseEnter += (sender, e) => { button.BackColor = Color.FromArgb(43, 49, 65); };

            //press
            button.MouseDown += (sender, e) => { button.BackColor = Color.FromArgb(34, 40, 54); };

            button.EnabledChanged += (sender, e) =>
            {
                if (!button.Enabled)
                {

                }
            };

        }

        public static void MyFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (Utilities.mainPanel != null && Utilities.mainPanel != sender)
            {
                e.Cancel = true;

                Utilities.mainPanel.Close();
                return;
            }

            var result = PopupForm.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) e.Cancel = true;
            else Environment.Exit(0);

        }

        public static bool IsPasswordSufficient(string password)
        {
            return true;
        }

        public static void RefreshData()
        {
            DocumentType.LoadDocumentTypes();
            Request.LoadRequests();
            User.LoadUsers();
            Notification.LoadNotifications();

            if (User.CurrentUser != null)
            {
                string id = User.CurrentUser.ID;
                User.CurrentUser = User.Users.FirstOrDefault(user => user.ID == id);
            }
        }

        public static bool AddDataFromExcel()
        {
            try
            {
                string path = "";
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
                    openFileDialog.Title = "Select an Excel File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (string.IsNullOrWhiteSpace(path) || !Path.Exists(path)) throw new Exception("Invalid path");

                Request.AddDataFromExcel(path);
                return true;
            }
            catch (Exception ex)
            {
                PopupForm.Show(ex.Message, "Error");
                return false;
            }


        }

        internal static void SendEmail(Request request)
        {
            try
            {
                // Gmail SMTP server details
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587; // Use 465 for SSL
                bool enableSSL = true;

                // Sender's email credentials
                string emailFrom = "bpcregistaroffice2024@gmail.com";
                string password = "sxqxhiuuklxsinlo"; // Use App Password if 2FA is enabled

                // Recipient and email content
                string emailTo = request.Email;
                string subject = request.RequestType.ToString();
                string body;

                if (request.Status == RequestStatus.Declined)
                {
                    body = "Your request for " + request.RequestType.Type + " has been declined." +
                            "\n Please contact us for more information.";
                }
                else
                {
                    body = "Your request for " + request.RequestType.Type + " has been accepted." +
                            "\n Please pick it up at the specified date and time " + request.DateClaiming.Value.ToString("MM/dd/yyyy hh:mm tt");
                }

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Set to true if the body contains HTML

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        Console.WriteLine("Email sent successfully!", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                PopupForm.Show($"Failed to send email. Error: {ex.Message}", "Error");
            }
        }

        private static void SendEmailToAdmin(Request request)
        {
            try
            {
                // Gmail SMTP server details
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587; // Use 465 for SSL
                bool enableSSL = true;

                // Sender's email credentials
                string emailFrom = "bpcregistaroffice2024@gmail.com";
                string password = "sxqxhiuuklxsinlo"; // Use App Password if 2FA is enabled

                // Recipient and email content
                string subject = "Document Printed";
                string body = User.CurrentUser?.FullName + " has printed " + request.RequestType.Type + " for " + request.FullName + " at " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    foreach (User user in User.Users)
                    {
                        if (user.Role == UserType.Admin) mail.To.Add(user.Email);
                    }
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Set to true if the body contains HTML

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        Console.WriteLine("Email sent successfully!", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email. Error: {ex.Message}", "Error");
            }
        }

        public static void Print(Request request)
        {
            try
            {
                if (User.CurrentUser == null) return;

                User user = User.CurrentUser;

                string templatePath = @"Document.docx";
                string tempDocxLocation = @"temp.docx";
                string temphtmlLocation = @"test1.html";
                if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");
                string PDFPath = @"Data/" + request.ReferenceNumber + "-" + request.RequestType.Type.Trim() + "-" + request.FullName + ".pdf";

                StringBuilder content = new StringBuilder();
                DocX temp = DocX.Load(templatePath);
                // Replace placeholders with dynamic data
                temp.ReplaceText("{DocumentType}", request.RequestType.ToString());
                temp.ReplaceText("{UserFullName}", request.FullName);
                temp.ReplaceText("{Address}", request.Address);
                temp.ReplaceText("{ContactNum}", request.MobileNumber);
                temp.ReplaceText("{CourseAndSection}", request.Course + " - " + request.Section);

                // Save the modified document
                
                temp.SaveAs(tempDocxLocation);
                temp.Dispose();

                var fileInfo = new FileInfo(tempDocxLocation);
                string fullFilePath = fileInfo.FullName;
                string htmlText = string.Empty;
                try
                {
                    htmlText = ParseDOCX(fileInfo);
                }
                catch (OpenXmlPackageException e)
                {
                    if (e.ToString().Contains("Invalid Hyperlink"))
                    {
                        using (FileStream fs = new FileStream(fullFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            UriFixer.FixInvalidUri(fs, brokenUri => FixUri(brokenUri));
                        }
                        htmlText = ParseDOCX(fileInfo);
                    }
                }

                var writer = File.CreateText(temphtmlLocation);
                writer.WriteLine(htmlText.ToString());
                writer.Dispose();
                File.Delete(tempDocxLocation);

                var converter = new SynchronizedConverter(new PdfTools());
                var doc = new HtmlToPdfDocument()
                {
                    GlobalSettings = new GlobalSettings
                    {
                        ColorMode = DinkToPdf.ColorMode.Color,
                        Orientation = DinkToPdf.Orientation.Portrait,
                        PaperSize = PaperKind.A4,
                    },
                                    Objects = {
                        new ObjectSettings() {
                            PagesCount = true,
                            HtmlContent = File.ReadAllText(temphtmlLocation),
                            WebSettings = { DefaultEncoding = "utf-8" }
                        }
                    }
                };

                byte[] pdf = converter.Convert(doc);
                File.Delete(temphtmlLocation);


                // Save to file
                File.WriteAllBytes(PDFPath, pdf);
                Console.WriteLine("PDF created successfully!");

                request.UpdateToArchived();
                SendEmailToAdmin(request);

                PopupForm.Show("Print successful", "Success");
            }
            catch (Exception e)
            {
                PopupForm.Show(e.Message, "Error");
            }
        }

        private static Uri FixUri(string brokenUri)
        {
            string newURI = string.Empty;
            if (brokenUri.Contains("mailto:"))
            {
                int mailToCount = "mailto:".Length;
                brokenUri = brokenUri.Remove(0, mailToCount);
                newURI = brokenUri;
            }
            else
            {
                newURI = " ";
            }
            return new Uri(newURI);
        }

        private static string ParseDOCX(FileInfo fileInfo)
        {
            try
            {
                byte[] byteArray = File.ReadAllBytes(fileInfo.FullName);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(byteArray, 0, byteArray.Length);
                    using (WordprocessingDocument wDoc =
                                                WordprocessingDocument.Open(memoryStream, true))
                    {
                        int imageCounter = 0;
                        var pageTitle = fileInfo.FullName;
                        var part = wDoc.CoreFilePropertiesPart;
                        if (part != null)
                            pageTitle = (string)part.GetXDocument()
                                                    .Descendants(DC.title)
                                                    .FirstOrDefault() ?? fileInfo.FullName;

                        WmlToHtmlConverterSettings settings = new WmlToHtmlConverterSettings()
                        {
                            AdditionalCss = "body { margin: 1cm auto; max-width: 20cm; padding: 0; }",
                            PageTitle = pageTitle,
                            FabricateCssClasses = true,
                            CssClassPrefix = "pt-",
                            RestrictToSupportedLanguages = false,
                            RestrictToSupportedNumberingFormats = false,
                            ImageHandler = imageInfo =>
                            {
                                ++imageCounter;
                                string extension = imageInfo.ContentType.Split('/')[1].ToLower();
                                ImageFormat imageFormat = null;
                                if (extension == "png") imageFormat = ImageFormat.Png;
                                else if (extension == "gif") imageFormat = ImageFormat.Gif;
                                else if (extension == "bmp") imageFormat = ImageFormat.Bmp;
                                else if (extension == "jpeg") imageFormat = ImageFormat.Jpeg;
                                else if (extension == "tiff")
                                {
                                    extension = "gif";
                                    imageFormat = ImageFormat.Gif;
                                }
                                else if (extension == "x-wmf")
                                {
                                    extension = "wmf";
                                    imageFormat = ImageFormat.Wmf;
                                }

                                if (imageFormat == null) return null;

                                string base64 = null;
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        imageInfo.Bitmap.Save(ms, imageFormat);
                                        var ba = ms.ToArray();
                                        base64 = System.Convert.ToBase64String(ba);
                                    }
                                }
                                catch (System.Runtime.InteropServices.ExternalException)
                                { return null; }

                                ImageFormat format = imageInfo.Bitmap.RawFormat;
                                ImageCodecInfo codec = ImageCodecInfo.GetImageDecoders()
                                                            .First(c => c.FormatID == format.Guid);
                                string mimeType = codec.MimeType;

                                string imageSource =
                                        string.Format("data:{0};base64,{1}", mimeType, base64);

                                XElement img = new XElement(Xhtml.img,
                                        new XAttribute(NoNamespace.src, imageSource),
                                        imageInfo.ImgStyleAttribute,
                                        imageInfo.AltText != null ?
                                            new XAttribute(NoNamespace.alt, imageInfo.AltText) : null);
                                return img;
                            }
                        };

                        XElement htmlElement = WmlToHtmlConverter.ConvertToHtml(wDoc, settings);
                        var html = new XDocument(new XDocumentType("html", null, null, null),
                                                                                    htmlElement);
                        var htmlString = html.ToString(SaveOptions.DisableFormatting);
                        return htmlString;
                    }
                }
            }
            catch
            {
                return "The file is either open, please close it or contains corrupt data";
            }

        }

        public static void BackHome()
        {
            if (File.Exists("ButtonV2.dll") || File.Exists("ButtonV2.mp4")) new PopupV2().Show();
        }
    }
}
