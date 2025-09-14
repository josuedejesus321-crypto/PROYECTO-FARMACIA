![Nuget](https://img.shields.io/nuget/v/BarCode?color=informational&label=latest)  ![Installs](https://img.shields.io/nuget/dt/BarCode?color=informational&label=installs&logo=nuget)  ![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20413%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)  [![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=data:image/svg%2bxml;base64,PHN2ZyByb2xlPSJpbWciIHZpZXdCb3g9IjAgMCAyNCAyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCiAgPHRpdGxlPldpbmRvd3M8L3RpdGxlPg0KICA8cGF0aCBmaWxsPSJ3aGl0ZSIgZD0iTTAsMEgxMS4zNzdWMTEuMzcySDBaTTEyLjYyMywwSDI0VjExLjM3MkgxMi42MjNaTTAsMTIuNjIzSDExLjM3N1YyNEgwWm0xMi42MjMsMEgyNFYyNEgxMi42MjMiLz4NCjwvc3ZnPg==)](https://ironsoftware.com/csharp/barcode/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)](https://ironsoftware.com/csharp/barcode/get-started/macos/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)](https://ironsoftware.com/csharp/barcode/docs/questions/linux/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)](https://ironsoftware.com/csharp/barcode/get-started/docker-linux/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=data:image/svg%2bxml;base64,PHN2ZyByb2xlPSJpbWciIHZpZXdCb3g9IjAgMCAyNCAyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48dGl0bGU+QW1hem9uIEFXUzwvdGl0bGU+PHBhdGggZmlsbD0id2hpdGUiICAgZD0iTTYuNzYzIDEwLjAzNmMwIC4yOTYuMDMyLjUzNS4wODguNzEuMDY0LjE3Ni4xNDQuMzY4LjI1Ni41NzYuMDQuMDYzLjA1Ni4xMjcuMDU2LjE4MyAwIC4wOC0uMDQ4LjE2LS4xNTIuMjRsLS41MDMuMzM1YS4zODMuMzgzIDAgMCAxLS4yMDguMDcyYy0uMDggMC0uMTYtLjA0LS4yMzktLjExMmEyLjQ3IDIuNDcgMCAwIDEtLjI4Ny0uMzc1IDYuMTggNi4xOCAwIDAgMS0uMjQ4LS40NzFjLS42MjIuNzM0LTEuNDA1IDEuMTAxLTIuMzQ3IDEuMTAxLS42NyAwLTEuMjA1LS4xOTEtMS41OTYtLjU3NC0uMzkxLS4zODQtLjU5LS44OTQtLjU5LTEuNTMzIDAtLjY3OC4yMzktMS4yMy43MjYtMS42NDQuNDg3LS40MTUgMS4xMzMtLjYyMyAxLjk1NS0uNjIzLjI3MiAwIC41NTEuMDI0Ljg0Ni4wNjQuMjk2LjA0LjYuMTA0LjkxOC4xNzZ2LS41ODNjMC0uNjA3LS4xMjctMS4wMy0uMzc1LTEuMjc3LS4yNTUtLjI0OC0uNjg2LS4zNjctMS4zLS4zNjctLjI4IDAtLjU2OC4wMzEtLjg2My4xMDMtLjI5NS4wNzItLjU4My4xNi0uODYyLjI3MmEyLjI4NyAyLjI4NyAwIDAgMS0uMjguMTA0LjQ4OC40ODggMCAwIDEtLjEyNy4wMjNjLS4xMTIgMC0uMTY4LS4wOC0uMTY4LS4yNDd2LS4zOTFjMC0uMTI4LjAxNi0uMjI0LjA1Ni0uMjhhLjU5Ny41OTcgMCAwIDEgLjIyNC0uMTY3Yy4yNzktLjE0NC42MTQtLjI2NCAxLjAwNS0uMzZhNC44NCA0Ljg0IDAgMCAxIDEuMjQ2LS4xNTFjLjk1IDAgMS42NDQuMjE2IDIuMDkxLjY0Ny40MzkuNDMuNjYyIDEuMDg1LjY2MiAxLjk2M3YyLjU4NnptLTMuMjQgMS4yMTRjLjI2MyAwIC41MzQtLjA0OC44MjItLjE0NC4yODctLjA5Ni41NDMtLjI3MS43NTgtLjUxLjEyOC0uMTUyLjIyNC0uMzIuMjcyLS41MTIuMDQ3LS4xOTEuMDgtLjQyMy4wOC0uNjk0di0uMzM1YTYuNjYgNi42NiAwIDAgMC0uNzM1LS4xMzYgNi4wMiA2LjAyIDAgMCAwLS43NS0uMDQ4Yy0uNTM1IDAtLjkyNi4xMDQtMS4xOS4zMi0uMjYzLjIxNS0uMzkuNTE4LS4zOS45MTcgMCAuMzc1LjA5NS42NTUuMjk1Ljg0Ni4xOTEuMi40Ny4yOTYuODM4LjI5NnptNi40MS44NjJjLS4xNDQgMC0uMjQtLjAyNC0uMzA0LS4wOC0uMDY0LS4wNDgtLjEyLS4xNi0uMTY4LS4zMTFMNy41ODYgNS41NWExLjM5OCAxLjM5OCAwIDAgMS0uMDcyLS4zMmMwLS4xMjguMDY0LS4yLjE5MS0uMmguNzgzYy4xNTEgMCAuMjU1LjAyNS4zMS4wOC4wNjUuMDQ4LjExMy4xNi4xNi4zMTJsMS4zNDIgNS4yODQgMS4yNDUtNS4yODRjLjA0LS4xNi4wODgtLjI2NC4xNTEtLjMxMmEuNTQ5LjU0OSAwIDAgMSAuMzItLjA4aC42MzhjLjE1MiAwIC4yNTYuMDI1LjMyLjA4LjA2My4wNDguMTIuMTYuMTUxLjMxMmwxLjI2MSA1LjM0OCAxLjM4MS01LjM0OGMuMDQ4LS4xNi4xMDQtLjI2NC4xNi0uMzEyYS41Mi41MiAwIDAgMSAuMzExLS4wOGguNzQzYy4xMjcgMCAuMi4wNjUuMi4yIDAgLjA0LS4wMDkuMDgtLjAxNy4xMjhhMS4xMzcgMS4xMzcgMCAwIDEtLjA1Ni4ybC0xLjkyMyA2LjE3Yy0uMDQ4LjE2LS4xMDQuMjYzLS4xNjguMzExYS41MS41MSAwIDAgMS0uMzAzLjA4aC0uNjg3Yy0uMTUxIDAtLjI1NS0uMDI0LS4zMi0uMDgtLjA2My0uMDU2LS4xMTktLjE2LS4xNS0uMzJsLTEuMjM4LTUuMTQ4LTEuMjMgNS4xNGMtLjA0LjE2LS4wODcuMjY0LS4xNS4zMi0uMDY1LjA1Ni0uMTc3LjA4LS4zMi4wOHptMTAuMjU2LjIxNWMtLjQxNSAwLS44My0uMDQ4LTEuMjI5LS4xNDMtLjM5OS0uMDk2LS43MS0uMi0uOTE4LS4zMi0uMTI4LS4wNzEtLjIxNS0uMTUxLS4yNDctLjIyM2EuNTYzLjU2MyAwIDAgMS0uMDQ4LS4yMjR2LS40MDdjMC0uMTY3LjA2NC0uMjQ3LjE4My0uMjQ3LjA0OCAwIC4wOTYuMDA4LjE0NC4wMjQuMDQ4LjAxNi4xMi4wNDguMi4wOC4yNzEuMTIuNTY2LjIxNS44NzguMjc5LjMxOS4wNjQuNjMuMDk2Ljk1LjA5Ni41MDIgMCAuODk0LS4wODggMS4xNjUtLjI2NGEuODYuODYgMCAwIDAgLjQxNS0uNzU4Ljc3Ny43NzcgMCAwIDAtLjIxNS0uNTU5Yy0uMTQ0LS4xNTEtLjQxNi0uMjg3LS44MDctLjQxNWwtMS4xNTctLjM2Yy0uNTgzLS4xODMtMS4wMTQtLjQ1NC0xLjI3Ny0uODEzYTEuOTAyIDEuOTAyIDAgMCAxLS40LTEuMTU4YzAtLjMzNS4wNzMtLjYzLjIxNi0uODg2LjE0NC0uMjU1LjMzNS0uNDc5LjU3NS0uNjU0LjI0LS4xODQuNTEtLjMyLjgzLS40MTUuMzItLjA5Ni42NTUtLjEzNiAxLjAwNi0uMTM2LjE3NSAwIC4zNTkuMDA4LjUzNS4wMzIuMTgzLjAyNC4zNS4wNTYuNTE4LjA4OC4xNi4wNC4zMTIuMDguNDU1LjEyNy4xNDQuMDQ4LjI1Ni4wOTYuMzM2LjE0NGEuNjkuNjkgMCAwIDEgLjI0LjIuNDMuNDMgMCAwIDEgLjA3MS4yNjN2LjM3NWMwIC4xNjgtLjA2NC4yNTYtLjE4NC4yNTZhLjgzLjgzIDAgMCAxLS4zMDMtLjA5NiAzLjY1MiAzLjY1MiAwIDAgMC0xLjUzMi0uMzExYy0uNDU1IDAtLjgxNS4wNzEtMS4wNjIuMjIzLS4yNDguMTUyLS4zNzUuMzgzLS4zNzUuNzEgMCAuMjI0LjA4LjQxNi4yNC41NjcuMTU5LjE1Mi40NTQuMzA0Ljg3Ny40NGwxLjEzNC4zNThjLjU3NC4xODQuOTkuNDQgMS4yMzcuNzY3LjI0Ny4zMjcuMzY3LjcwMi4zNjcgMS4xMTcgMCAuMzQzLS4wNzIuNjU1LS4yMDcuOTI2LS4xNDQuMjcyLS4zMzYuNTExLS41ODMuNzAzLS4yNDguMi0uNTQzLjM0My0uODg2LjQ0Ny0uMzYuMTExLS43MzQuMTY3LTEuMTQyLjE2N3pNMjEuNjk4IDE2LjIwN2MtMi42MjYgMS45NC02LjQ0MiAyLjk2OS05LjcyMiAyLjk2OS00LjU5OCAwLTguNzQtMS43LTExLjg3LTQuNTI2LS4yNDctLjIyMy0uMDI0LS41MjcuMjcyLS4zNTEgMy4zODQgMS45NjMgNy41NTkgMy4xNTMgMTEuODc3IDMuMTUzIDIuOTE0IDAgNi4xMTQtLjYwNyA5LjA2LTEuODUyLjQzOS0uMi44MTQuMjg3LjM4My42MDd6TTIyLjc5MiAxNC45NjFjLS4zMzYtLjQzLTIuMjItLjIwNy0zLjA3NC0uMTAzLS4yNTUuMDMyLS4yOTUtLjE5Mi0uMDYzLS4zNiAxLjUtMS4wNTMgMy45NjctLjc1IDQuMjU0LS4zOTkuMjg3LjM2LS4wOCAyLjgyNi0xLjQ4NSA0LjAwNy0uMjE1LjE4NC0uNDIzLjA4OC0uMzI3LS4xNTEuMzItLjc5IDEuMDMtMi41Ny42OTUtMi45OTR6Ii8+PC9zdmc+)](https://ironsoftware.com/csharp/barcode/get-started/aws/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=data:image/svg%2bxml;base64,PHN2ZyByb2xlPSJpbWciIHZpZXdCb3g9IjAgMCAyNCAyNCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48dGl0bGU+TWljcm9zb2Z0IEF6dXJlPC90aXRsZT48cGF0aCBmaWxsPSJ3aGl0ZSIgZD0iTTIyLjM3OSAyMy4zNDNhMS42MiAxLjYyIDAgMCAwIDEuNTM2LTIuMTR2LjAwMkwxNy4zNSAxLjc2QTEuNjIgMS42MiAwIDAgMCAxNS44MTYuNjU3SDguMTg0QTEuNjIgMS42MiAwIDAgMCA2LjY1IDEuNzZMLjA4NiAyMS4yMDRhMS42MiAxLjYyIDAgMCAwIDEuNTM2IDIuMTM5aDQuNzQxYTEuNjIgMS42MiAwIDAgMCAxLjUzNS0xLjEwM2wuOTc3LTIuODkyIDQuOTQ3IDMuNjc1Yy4yOC4yMDguNjE4LjMyLjk2Ni4zMm0tMy4wODQtMTIuNTMxIDMuNjI0IDEwLjczOWEuNTQuNTQgMCAwIDEtLjUxLjcxM3YtLjAwMWgtLjAzYS41NC41NCAwIDAgMS0uMzIyLS4xMDZsLTkuMjg3LTYuOWg0Ljg1M202LjMxMyA3LjAwNmMuMTE2LS4zMjYuMTMtLjY5NC4wMDctMS4wNThMOS43OSAxLjc2YTEuNzIyIDEuNzIyIDAgMCAwLS4wMDctLjAyaDYuMDM0YS41NC41NCAwIDAgMSAuNTEyLjM2Nmw2LjU2MiAxOS40NDVhLjU0LjU0IDAgMCAxLS4zMzguNjg0Ii8+PC9zdmc+)](https://ironsoftware.com/csharp/barcode/get-started/azure/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![livechat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/barcode/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

# IronBarcode - The C# Barcode & QR Code Library


[![IronBarcode NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronBarcode-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/barcode/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

[Get Started](https://ironsoftware.com/csharp/barcode/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Features](https://ironsoftware.com/csharp/barcode/features/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Code Examples](https://ironsoftware.com/csharp/barcode/examples/barcode-quickstart/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Licensing](https://ironsoftware.com/csharp/barcode/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Free Trial](https://ironsoftware.com/csharp/barcode/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation#trial-license)

IronBarcode is a library developed and maintained by Iron Software that helps C# Software Engineers to read & write Barcodes and QR Codes in .NET applications & websites. Reading or writing barcodes only requires a single line of code with IronBarcode.
 
### IronBarcode excels at:
- Read single or multiple Barcodes and QR Codes from images or PDFs.
- Image correction for skewing, orientation, noise, low resolution, contrast etc.
- Create barcodes and apply to images or PDF documents.
- Embed barcodes into HTML documents.
- Style Barcodes and add annotation text.
- QR Code Writing allows adding of logos, colors, and advanced QR alignment.

### IronBarcode has cross platform support compatibility with:
- **.NET 9**, **.NET 8**, .NET 7, .NET 6, .NET 5, Core 2x & 3x, Standard 2 and Framework 4x
- Windows, MacOS, Linux, Docker, Azure and AWS

[![IronBarcode Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronBarcode-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/barcode/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)


Additionally, our [API reference](https://ironsoftware.com/csharp/barcode/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) and [full licensing information](https://ironsoftware.com/csharp/barcode/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#trial-license) can easily be found on our website.

## Using IronBarcode

Installing the IronBarcode NuGet package is quick and easy, please install the package like this:
```
PM> Install-Package BarCode
```
Once installed, you can get started by adding `using IronBarCode` to the top of your C# code. Here is is sample Barcode Generating, Reading, and Saving example to get started:
```csharp
using IronBarCode;

// Creating a barcode is as simple as:
var myBarcode = BarcodeWriter.CreateBarcode("12345", BarcodeWriterEncoding.EAN8);

// Reading a barcode is easy with IronBarcode:
var resultFromFile = BarcodeReader.Read(@"file/barcode.png"); // From a file
var resultFromPdf = BarcodeReader.ReadPdf(@"file/mydocument.pdf"); // From PDF use ReadPdf

// After creating a barcode, we may choose to resize and save which is easily done with:
myBarcode.ResizeTo(400, 100);
myBarcode.SaveAsImage("myBarcodeResized.jpeg");
```
## Features Table
[![IronBarcode Features](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronBarcode-readme/features-table.png)](https://ironsoftware.com/csharp/barcode/features/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

The .NET IronBarcode Library reads and writes most Barcode and QR standards. These include code 39/93/128, UPC A/E, EAN 8/13, ITF, RSS 14 / Expanded, Databar, CodaBar, Aztec, Data Matrix, MaxiCode, PDF417, MSI, Plessey, USPS, and QR. The barcode result data includes type, text, binary data, page, and image file.

The barcode reading engine includes automatic image correction and barcode detection technology to take the pain out of locating and reading from imperfect scans. Multithreading, cropping, and batch scanning provides fast and accurate scanning of multi page documents.

Barcode writing API checks and verifies format, length, number, checksum to automatically avoid encoding errors. Barcode writer allows for styling, resizing, margins, borders, recoloring, and adding text annotations. Write to image, PDF or HTML file.
#### Supported Barcode Formats:
- QR & 2D Matrix: QR (+ Styled QR), Aztec, Data Matrix, MaxiCode (Read Only) USPS IM Barcode (Read Only)
- Modern Linear Barcodes: Code 39, Code 128, PDF417, Rss14 (Read Only), RSS Expanded (Read Only)
- Older Linear Barcodes: UPC-A, UPC-E, EAN-8, EAN-13, Codabar, ITF, MSI, Plessey (Write Only)

#### Reading Barcodes:
- Read from many image formats: Images (JPG, PNG, GIF, TIFF, SVG, BMP), Multipage GIF & TIFF, System.Drawing Objects, Streams, PDF, and more
- Image Filters to improve image reading: Brightness, Contrast, Invert, Sharpen, and many more!
- Set Accuracy & Performance: Single / Multi Barcode Reading, Specify Crop Regions, Set Output Format, Multithreading Support
- Output to many data formats: Text Data, Numerical Data, Binary Data, Barcode Image
#### Writing Barcodes:
- Write To Document Types: Image (jpg, png, gif, tiff, bmp), System.Drawing Objects, Streams, HTML (DataURI, file, or img), PDF (File, Stream, or Binary), Existing PDF (Stamp position)
- Encoding Barcode Data: Text, urls, IDs, numbers, & binary data
- Checking Fault Tolerance: Null Check, Checksums, Format Aware, Detailed Error messages, Custom QR Error Correction
- Styling Barcodes: Resizing, Margins & Borders, Recoloring, Add text annotations, Add logos to QR

## Licensing & Support available
For code examples, tutorials and documentation visit https://ironsoftware.com/csharp/barcode/

For support please email us at developers@ironsoftware.com 

## Documentation Links

-   Code Examples : [(https://ironsoftware.com/csharp/barcode/examples/barcode-quickstart/](https://ironsoftware.com/csharp/barcode/examples/barcode-quickstart/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   API Reference : [https://ironsoftware.com/csharp/barcode/object-reference/api/](https://ironsoftware.com/csharp/barcode/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   Tutorials : [https://ironsoftware.com/csharp/barcode/tutorials/csharp-barcode-image-generator/](https://ironsoftware.com/csharp/barcode/tutorials/csharp-barcode-image-generator/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
-   Licensing : [https://ironsoftware.com/csharp/barcode/licensing/](https://ironsoftware.com/csharp/barcode/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
- Live Chat Support : [https://ironsoftware.com/csharp/barcode/#helpscout-support](https://ironsoftware.com/csharp/barcode/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)

You can email us at developers@ironsoftware.com for support directly from our code team. We offer licensing and extensive support for commercial deployment projects.
