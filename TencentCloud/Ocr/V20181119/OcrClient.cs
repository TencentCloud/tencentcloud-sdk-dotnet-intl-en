/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ocr.V20181119.Models;

   public class OcrClient : AbstractClient{

       private const string endpoint = "ocr.tencentcloudapi.com";
       private const string version = "2018-11-19";
       private const string sdkVersion = "SDK_NET_3.0.992";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to detect and recognize key fields such as the card number, bank information, and expiration date on mainstream bank cards in Mainland China.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public Task<BankCardOCRResponse> BankCardOCR(BankCardOCRRequest req)
        {
            return InternalRequestAsync<BankCardOCRResponse>(req, "BankCardOCR");
        }

        /// <summary>
        /// This API is used to detect and recognize key fields such as the card number, bank information, and expiration date on mainstream bank cards in Mainland China.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public BankCardOCRResponse BankCardOCRSync(BankCardOCRRequest req)
        {
            return InternalRequestAsync<BankCardOCRResponse>(req, "BankCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image. It can recognize Chinese, English, Chinese-English, digits, and special symbols and return the text box positions and characters.
        /// 
        /// It is suitable for scenarios with a lot of characters in complex layouts and requiring high recognition accuracy, such as examination papers, online images, signboards, and legal documents.
        /// 
        /// Strengths: compared with general print recognition, it provides higher-precision character recognition services. Its accuracy and recall rate are higher in difficult scenarios such as a large number of characters, long strings of digits, small characters, blurry characters, and tilted text.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="GeneralAccurateOCRRequest"/></param>
        /// <returns><see cref="GeneralAccurateOCRResponse"/></returns>
        public Task<GeneralAccurateOCRResponse> GeneralAccurateOCR(GeneralAccurateOCRRequest req)
        {
            return InternalRequestAsync<GeneralAccurateOCRResponse>(req, "GeneralAccurateOCR");
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image. It can recognize Chinese, English, Chinese-English, digits, and special symbols and return the text box positions and characters.
        /// 
        /// It is suitable for scenarios with a lot of characters in complex layouts and requiring high recognition accuracy, such as examination papers, online images, signboards, and legal documents.
        /// 
        /// Strengths: compared with general print recognition, it provides higher-precision character recognition services. Its accuracy and recall rate are higher in difficult scenarios such as a large number of characters, long strings of digits, small characters, blurry characters, and tilted text.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="GeneralAccurateOCRRequest"/></param>
        /// <returns><see cref="GeneralAccurateOCRResponse"/></returns>
        public GeneralAccurateOCRResponse GeneralAccurateOCRSync(GeneralAccurateOCRRequest req)
        {
            return InternalRequestAsync<GeneralAccurateOCRResponse>(req, "GeneralAccurateOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image in the following 20 languages: Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, Thai, and Arabic. Mixed characters in English and each supported language can be recognized together.
        /// 
        /// It can recognize printed text in paper documents, online images, ads, signboards, menus, video titles, profile photos, etc.
        /// 
        /// Strengths: it can automatically recognize the text language, return the text box coordinate information, and automatically rotate tilted text to the upright direction.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public Task<GeneralBasicOCRResponse> GeneralBasicOCR(GeneralBasicOCRRequest req)
        {
            return InternalRequestAsync<GeneralBasicOCRResponse>(req, "GeneralBasicOCR");
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image in the following 20 languages: Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, Thai, and Arabic. Mixed characters in English and each supported language can be recognized together.
        /// 
        /// It can recognize printed text in paper documents, online images, ads, signboards, menus, video titles, profile photos, etc.
        /// 
        /// Strengths: it can automatically recognize the text language, return the text box coordinate information, and automatically rotate tilted text to the upright direction.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public GeneralBasicOCRResponse GeneralBasicOCRSync(GeneralBasicOCRRequest req)
        {
            return InternalRequestAsync<GeneralBasicOCRResponse>(req, "GeneralBasicOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize key fields on the photo side of a Hong Kong (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. 
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public Task<HKIDCardOCRResponse> HKIDCardOCR(HKIDCardOCRRequest req)
        {
            return InternalRequestAsync<HKIDCardOCRResponse>(req, "HKIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize key fields on the photo side of a Hong Kong (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. 
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public HKIDCardOCRResponse HKIDCardOCRSync(HKIDCardOCRRequest req)
        {
            return InternalRequestAsync<HKIDCardOCRResponse>(req, "HKIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize key fields on the front and back sides of a residence permit for Hong Kong, Macao, or Taiwan residents, including name, gender, date of birth, address, ID number, issuing authority, validity period, number of issues, and permit number. It can be used for residence permit OCR in scenarios such as bank account opening and user registration.
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="HmtResidentPermitOCRRequest"/></param>
        /// <returns><see cref="HmtResidentPermitOCRResponse"/></returns>
        public Task<HmtResidentPermitOCRResponse> HmtResidentPermitOCR(HmtResidentPermitOCRRequest req)
        {
            return InternalRequestAsync<HmtResidentPermitOCRResponse>(req, "HmtResidentPermitOCR");
        }

        /// <summary>
        /// This API is used to recognize key fields on the front and back sides of a residence permit for Hong Kong, Macao, or Taiwan residents, including name, gender, date of birth, address, ID number, issuing authority, validity period, number of issues, and permit number. It can be used for residence permit OCR in scenarios such as bank account opening and user registration.
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="HmtResidentPermitOCRRequest"/></param>
        /// <returns><see cref="HmtResidentPermitOCRResponse"/></returns>
        public HmtResidentPermitOCRResponse HmtResidentPermitOCRSync(HmtResidentPermitOCRRequest req)
        {
            return InternalRequestAsync<HmtResidentPermitOCRResponse>(req, "HmtResidentPermitOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize all fields on the front and back sides of a second-generation resident identity card for the Chinese mainland: name, gender, ethnicity, date of birth, domicile, identification number, issuing authority, and validity period, with a recognition accuracy of over 99%.
        /// 
        /// In addition, this API supports multiple value-added capabilities to meet the needs of different scenarios. It can crop ID card photos and profile photos, and provide warnings for nine cases, as detailed below.
        /// 
        /// <table style="width:650px">
        ///       <thead>
        ///         <tr>
        ///        <th width="150">Capability</th>
        ///           <th width="500">Description</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td rowspan="2">Cropping</td>
        ///           <td>Crops the ID card photo (by removing extra edges outside the ID card and automatically correcting the shooting angle).</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Crops the profile photo (by automatically cutting out the face area in the ID card).</td>
        ///         </tr>
        ///         <tr>
        ///           <td rowspan="9">Warning</td>
        ///           <td>Warns about invalid ID card validity periods.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about  incomplete ID card borders.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about photocopied images.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about spoofed images.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about border and frame occlusions.</td>
        ///         </tr>
        ///          <tr>
        ///           <td>Warns about temporary ID cards.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about photoshopped images.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about blurry ID card images (blurriness can be determined based on the image quality score).</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="IDCardOCRRequest"/></param>
        /// <returns><see cref="IDCardOCRResponse"/></returns>
        public Task<IDCardOCRResponse> IDCardOCR(IDCardOCRRequest req)
        {
            return InternalRequestAsync<IDCardOCRResponse>(req, "IDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize all fields on the front and back sides of a second-generation resident identity card for the Chinese mainland: name, gender, ethnicity, date of birth, domicile, identification number, issuing authority, and validity period, with a recognition accuracy of over 99%.
        /// 
        /// In addition, this API supports multiple value-added capabilities to meet the needs of different scenarios. It can crop ID card photos and profile photos, and provide warnings for nine cases, as detailed below.
        /// 
        /// <table style="width:650px">
        ///       <thead>
        ///         <tr>
        ///        <th width="150">Capability</th>
        ///           <th width="500">Description</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td rowspan="2">Cropping</td>
        ///           <td>Crops the ID card photo (by removing extra edges outside the ID card and automatically correcting the shooting angle).</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Crops the profile photo (by automatically cutting out the face area in the ID card).</td>
        ///         </tr>
        ///         <tr>
        ///           <td rowspan="9">Warning</td>
        ///           <td>Warns about invalid ID card validity periods.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about  incomplete ID card borders.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about photocopied images.</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Warns about spoofed images.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about border and frame occlusions.</td>
        ///         </tr>
        ///          <tr>
        ///           <td>Warns about temporary ID cards.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about photoshopped images.</td>
        ///         </tr>
        ///           <tr>
        ///           <td>Warns about blurry ID card images (blurriness can be determined based on the image quality score).</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="IDCardOCRRequest"/></param>
        /// <returns><see cref="IDCardOCRResponse"/></returns>
        public IDCardOCRResponse IDCardOCRSync(IDCardOCRRequest req)
        {
            return InternalRequestAsync<IDCardOCRResponse>(req, "IDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a license plate attached to a motor vehicle in the Chinese mainland and return the regional code, license plate number, and license plate color.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="LicensePlateOCRRequest"/></param>
        /// <returns><see cref="LicensePlateOCRResponse"/></returns>
        public Task<LicensePlateOCRResponse> LicensePlateOCR(LicensePlateOCRRequest req)
        {
            return InternalRequestAsync<LicensePlateOCRResponse>(req, "LicensePlateOCR");
        }

        /// <summary>
        /// This API is used to recognize a license plate attached to a motor vehicle in the Chinese mainland and return the regional code, license plate number, and license plate color.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="LicensePlateOCRRequest"/></param>
        /// <returns><see cref="LicensePlateOCRResponse"/></returns>
        public LicensePlateOCRResponse LicensePlateOCRSync(LicensePlateOCRRequest req)
        {
            return InternalRequestAsync<LicensePlateOCRResponse>(req, "LicensePlateOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Malaysian identity card, including identity card number, name, gender, and address. It is also used to crop identity photos and give alarms for photographed or photocopied certificates.
        /// 
        /// This API is not fully available for the time being. For more information, contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public Task<MLIDCardOCRResponse> MLIDCardOCR(MLIDCardOCRRequest req)
        {
            return InternalRequestAsync<MLIDCardOCRResponse>(req, "MLIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize a Malaysian identity card, including identity card number, name, gender, and address. It is also used to crop identity photos and give alarms for photographed or photocopied certificates.
        /// 
        /// This API is not fully available for the time being. For more information, contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public MLIDCardOCRResponse MLIDCardOCRSync(MLIDCardOCRRequest req)
        {
            return InternalRequestAsync<MLIDCardOCRResponse>(req, "MLIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public Task<MLIDPassportOCRResponse> MLIDPassportOCR(MLIDPassportOCRRequest req)
        {
            return InternalRequestAsync<MLIDPassportOCRResponse>(req, "MLIDPassportOCR");
        }

        /// <summary>
        /// This API is used to recognize a passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public MLIDPassportOCRResponse MLIDPassportOCRSync(MLIDPassportOCRRequest req)
        {
            return InternalRequestAsync<MLIDPassportOCRResponse>(req, "MLIDPassportOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize all fields on the front of a mainland travel permit for Hong Kong, Macao, or Taiwan residents: name in Chinese, name in English, gender, date of birth, issuing authority, validity period, document number, place of issuance, number of issues, and document type.
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="MainlandPermitOCRRequest"/></param>
        /// <returns><see cref="MainlandPermitOCRResponse"/></returns>
        public Task<MainlandPermitOCRResponse> MainlandPermitOCR(MainlandPermitOCRRequest req)
        {
            return InternalRequestAsync<MainlandPermitOCRResponse>(req, "MainlandPermitOCR");
        }

        /// <summary>
        /// This API is used to recognize all fields on the front of a mainland travel permit for Hong Kong, Macao, or Taiwan residents: name in Chinese, name in English, gender, date of birth, issuing authority, validity period, document number, place of issuance, number of issues, and document type.
        /// 
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="MainlandPermitOCRRequest"/></param>
        /// <returns><see cref="MainlandPermitOCRResponse"/></returns>
        public MainlandPermitOCRResponse MainlandPermitOCRSync(MainlandPermitOCRRequest req)
        {
            return InternalRequestAsync<MainlandPermitOCRResponse>(req, "MainlandPermitOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize the fields on an exit/entry permit (card) for traveling to and from Hong Kong, Macao, or Taiwan, including place of issuance, issuing authority, validity period, gender, date of birth, name in English, name in Chinese, and document number.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="PermitOCRRequest"/></param>
        /// <returns><see cref="PermitOCRResponse"/></returns>
        public Task<PermitOCRResponse> PermitOCR(PermitOCRRequest req)
        {
            return InternalRequestAsync<PermitOCRResponse>(req, "PermitOCR");
        }

        /// <summary>
        /// This API is used to recognize the fields on an exit/entry permit (card) for traveling to and from Hong Kong, Macao, or Taiwan, including place of issuance, issuing authority, validity period, gender, date of birth, name in English, name in Chinese, and document number.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="PermitOCRRequest"/></param>
        /// <returns><see cref="PermitOCRResponse"/></returns>
        public PermitOCRResponse PermitOCRSync(PermitOCRRequest req)
        {
            return InternalRequestAsync<PermitOCRResponse>(req, "PermitOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize various types of invoices or tickets in an image or PDF file. You can also specify a type. 14 types of standard expense reimbursement invoices are supported, including value-added tax (VAT) invoice (special, general, roll, blockchain, and toll), fully digitalized electronic invoice (special and general), non-tax revenue invoice (general receipt and general payment voucher), quota invoice, general machine-printed invoice, car sales invoice (motor vehicle sales invoice and used car invoice), train ticket, taxi receipt, itinerary/receipt of e-ticket for air transportation, bus ticket, ship ticket, toll receipt, and medical invoice (inpatient and outpatient). This API can also be used for intelligent recognition of other types of invoices. To try now, click [here](https://intl.cloud.tencent.com/product/ocr?from_cn_redirect=1).
        /// 
        /// A maximum of 5 requests can be initiated per second for this API.
        /// 
        /// 
        /// The invoice/ticket subtype (SubType), subtype description (TypeDescription), and parent type (Type) can be returned, as described below:
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:200px">SubType</th>
        ///           <th style="width:200px">TypeDescription</th>
        ///           <th >Type</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> VatSpecialInvoice</td>
        ///           <td> Special VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatCommonInvoice</td>
        ///           <td> General VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicCommonInvoice </td>
        ///           <td> Electronic general VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicSpecialInvoice </td>
        ///           <td> Electronic special VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceBlockchain</td>
        ///           <td> Blockchain electronic invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceToll</td>
        ///           <td> Electronic general VAT invoice (toll)</td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicSpecialInvoiceFull</td>
        ///           <td> Electronic invoice (special)</td>
        ///           <td> 16 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceFull</td>
        ///           <td> Electronic invoice (general) </td>
        ///           <td> 16 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> MotorVehicleSaleInvoice </td>
        ///           <td> Motor vehicle sales invoice </td>
        ///           <td> 12 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> UsedCarPurchaseInvoice </td>
        ///           <td> Used car invoice </td>
        ///           <td> 12 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatInvoiceRoll </td>
        ///           <td> General VAT invoice (roll) </td>
        ///           <td> 11 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TaxiTicket </td>
        ///           <td> Taxi receipt </td>
        ///           <td> 0 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> QuotaInvoice </td>
        ///           <td> Quota invoice </td>
        ///           <td> 1 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TrainTicket </td>
        ///           <td> Train ticket </td>
        ///           <td> 2 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> AirTransport </td>
        ///           <td> Itinerary/Receipt of e-ticket for air transportation </td>
        ///           <td> 5 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> MachinePrintedInvoice </td>
        ///           <td> General machine-printed invoice </td>
        ///           <td> 8 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> BusInvoice </td>
        ///           <td> Bus ticket </td>
        ///           <td> 9 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> ShippingInvoice </td>
        ///           <td> Ship ticket </td>
        ///           <td> 10 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> NonTaxIncomeGeneralBill </td>
        ///           <td> General receipt for non-tax revenue </td>
        ///           <td> 15 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> NonTaxIncomeElectronicBill </td>
        ///           <td> General payment voucher for non-tax revenue (electronic) </td>
        ///           <td> 15 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TollInvoice </td>
        ///           <td> Toll receipt </td>
        ///           <td> 13 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> OtherInvoice </td>
        ///           <td> Other </td>
        ///           <td> -1 </td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="RecognizeGeneralInvoiceRequest"/></param>
        /// <returns><see cref="RecognizeGeneralInvoiceResponse"/></returns>
        public Task<RecognizeGeneralInvoiceResponse> RecognizeGeneralInvoice(RecognizeGeneralInvoiceRequest req)
        {
            return InternalRequestAsync<RecognizeGeneralInvoiceResponse>(req, "RecognizeGeneralInvoice");
        }

        /// <summary>
        /// This API is used to recognize various types of invoices or tickets in an image or PDF file. You can also specify a type. 14 types of standard expense reimbursement invoices are supported, including value-added tax (VAT) invoice (special, general, roll, blockchain, and toll), fully digitalized electronic invoice (special and general), non-tax revenue invoice (general receipt and general payment voucher), quota invoice, general machine-printed invoice, car sales invoice (motor vehicle sales invoice and used car invoice), train ticket, taxi receipt, itinerary/receipt of e-ticket for air transportation, bus ticket, ship ticket, toll receipt, and medical invoice (inpatient and outpatient). This API can also be used for intelligent recognition of other types of invoices. To try now, click [here](https://intl.cloud.tencent.com/product/ocr?from_cn_redirect=1).
        /// 
        /// A maximum of 5 requests can be initiated per second for this API.
        /// 
        /// 
        /// The invoice/ticket subtype (SubType), subtype description (TypeDescription), and parent type (Type) can be returned, as described below:
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:200px">SubType</th>
        ///           <th style="width:200px">TypeDescription</th>
        ///           <th >Type</th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td> VatSpecialInvoice</td>
        ///           <td> Special VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatCommonInvoice</td>
        ///           <td> General VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicCommonInvoice </td>
        ///           <td> Electronic general VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicSpecialInvoice </td>
        ///           <td> Electronic special VAT invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceBlockchain</td>
        ///           <td> Blockchain electronic invoice </td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceToll</td>
        ///           <td> Electronic general VAT invoice (toll)</td>
        ///           <td> 3 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicSpecialInvoiceFull</td>
        ///           <td> Electronic invoice (special)</td>
        ///           <td> 16 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatElectronicInvoiceFull</td>
        ///           <td> Electronic invoice (general) </td>
        ///           <td> 16 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> MotorVehicleSaleInvoice </td>
        ///           <td> Motor vehicle sales invoice </td>
        ///           <td> 12 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> UsedCarPurchaseInvoice </td>
        ///           <td> Used car invoice </td>
        ///           <td> 12 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> VatInvoiceRoll </td>
        ///           <td> General VAT invoice (roll) </td>
        ///           <td> 11 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TaxiTicket </td>
        ///           <td> Taxi receipt </td>
        ///           <td> 0 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> QuotaInvoice </td>
        ///           <td> Quota invoice </td>
        ///           <td> 1 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TrainTicket </td>
        ///           <td> Train ticket </td>
        ///           <td> 2 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> AirTransport </td>
        ///           <td> Itinerary/Receipt of e-ticket for air transportation </td>
        ///           <td> 5 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> MachinePrintedInvoice </td>
        ///           <td> General machine-printed invoice </td>
        ///           <td> 8 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> BusInvoice </td>
        ///           <td> Bus ticket </td>
        ///           <td> 9 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> ShippingInvoice </td>
        ///           <td> Ship ticket </td>
        ///           <td> 10 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> NonTaxIncomeGeneralBill </td>
        ///           <td> General receipt for non-tax revenue </td>
        ///           <td> 15 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> NonTaxIncomeElectronicBill </td>
        ///           <td> General payment voucher for non-tax revenue (electronic) </td>
        ///           <td> 15 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> TollInvoice </td>
        ///           <td> Toll receipt </td>
        ///           <td> 13 </td>
        ///         </tr>
        ///         <tr>
        ///           <td> OtherInvoice </td>
        ///           <td> Other </td>
        ///           <td> -1 </td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="RecognizeGeneralInvoiceRequest"/></param>
        /// <returns><see cref="RecognizeGeneralInvoiceResponse"/></returns>
        public RecognizeGeneralInvoiceResponse RecognizeGeneralInvoiceSync(RecognizeGeneralInvoiceRequest req)
        {
            return InternalRequestAsync<RecognizeGeneralInvoiceResponse>(req, "RecognizeGeneralInvoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize an Indonesian identity card.
        /// 
        /// The API request rate is limited to 20 requests/sec by default.
        /// </summary>
        /// <param name="req"><see cref="RecognizeIndonesiaIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeIndonesiaIDCardOCRResponse"/></returns>
        public Task<RecognizeIndonesiaIDCardOCRResponse> RecognizeIndonesiaIDCardOCR(RecognizeIndonesiaIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeIndonesiaIDCardOCRResponse>(req, "RecognizeIndonesiaIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize an Indonesian identity card.
        /// 
        /// The API request rate is limited to 20 requests/sec by default.
        /// </summary>
        /// <param name="req"><see cref="RecognizeIndonesiaIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeIndonesiaIDCardOCRResponse"/></returns>
        public RecognizeIndonesiaIDCardOCRResponse RecognizeIndonesiaIDCardOCRSync(RecognizeIndonesiaIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeIndonesiaIDCardOCRResponse>(req, "RecognizeIndonesiaIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a South Korean driver's license.
        /// </summary>
        /// <param name="req"><see cref="RecognizeKoreanDrivingLicenseOCRRequest"/></param>
        /// <returns><see cref="RecognizeKoreanDrivingLicenseOCRResponse"/></returns>
        public Task<RecognizeKoreanDrivingLicenseOCRResponse> RecognizeKoreanDrivingLicenseOCR(RecognizeKoreanDrivingLicenseOCRRequest req)
        {
            return InternalRequestAsync<RecognizeKoreanDrivingLicenseOCRResponse>(req, "RecognizeKoreanDrivingLicenseOCR");
        }

        /// <summary>
        /// This API is used to recognize a South Korean driver's license.
        /// </summary>
        /// <param name="req"><see cref="RecognizeKoreanDrivingLicenseOCRRequest"/></param>
        /// <returns><see cref="RecognizeKoreanDrivingLicenseOCRResponse"/></returns>
        public RecognizeKoreanDrivingLicenseOCRResponse RecognizeKoreanDrivingLicenseOCRSync(RecognizeKoreanDrivingLicenseOCRRequest req)
        {
            return InternalRequestAsync<RecognizeKoreanDrivingLicenseOCRResponse>(req, "RecognizeKoreanDrivingLicenseOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a South Korean ID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizeKoreanIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeKoreanIDCardOCRResponse"/></returns>
        public Task<RecognizeKoreanIDCardOCRResponse> RecognizeKoreanIDCardOCR(RecognizeKoreanIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeKoreanIDCardOCRResponse>(req, "RecognizeKoreanIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize a South Korean ID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizeKoreanIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeKoreanIDCardOCRResponse"/></returns>
        public RecognizeKoreanIDCardOCRResponse RecognizeKoreanIDCardOCRSync(RecognizeKoreanIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeKoreanIDCardOCRResponse>(req, "RecognizeKoreanIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize key fields on the photo side of a Macao (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. 
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="RecognizeMacaoIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeMacaoIDCardOCRResponse"/></returns>
        public Task<RecognizeMacaoIDCardOCRResponse> RecognizeMacaoIDCardOCR(RecognizeMacaoIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeMacaoIDCardOCRResponse>(req, "RecognizeMacaoIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize key fields on the photo side of a Macao (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. 
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="RecognizeMacaoIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeMacaoIDCardOCRResponse"/></returns>
        public RecognizeMacaoIDCardOCRResponse RecognizeMacaoIDCardOCRSync(RecognizeMacaoIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeMacaoIDCardOCRResponse>(req, "RecognizeMacaoIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface supports the identification of all fields on the front and back of the second-generation ID card for mainland Chinese residents.Including name, gender, ethnicity, date of birth, address, citizen ID number, issuing authority, and validity period, the identification accuracy reaches more than 99%.In addition, this interface also supports a variety of value-added capabilities to meet the needs of different scenarios. Such as the cropping function of ID card photos and portrait photos, and also has 5 alarm functions.
        /// As shown in the table below. <table style="width:650px"> <thead> <tr> <th width="150">Value-added ability</th> <th width="500">Ability items</th> </tr> </thead> <tbody> <tr> <td rowspan="9">Alarm function</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>Alarm for occlusion in the ID card frame</td> </tr> <tr> <td>ID card reflective warning</td> </tr> <tr> <td>Blurry picture warning</td> </tr> </tbody> </table> Default interface request frequency limit: 20 times/second
        /// </summary>
        /// <param name="req"><see cref="RecognizeMainlandIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeMainlandIDCardOCRResponse"/></returns>
        public Task<RecognizeMainlandIDCardOCRResponse> RecognizeMainlandIDCardOCR(RecognizeMainlandIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeMainlandIDCardOCRResponse>(req, "RecognizeMainlandIDCardOCR");
        }

        /// <summary>
        /// This interface supports the identification of all fields on the front and back of the second-generation ID card for mainland Chinese residents.Including name, gender, ethnicity, date of birth, address, citizen ID number, issuing authority, and validity period, the identification accuracy reaches more than 99%.In addition, this interface also supports a variety of value-added capabilities to meet the needs of different scenarios. Such as the cropping function of ID card photos and portrait photos, and also has 5 alarm functions.
        /// As shown in the table below. <table style="width:650px"> <thead> <tr> <th width="150">Value-added ability</th> <th width="500">Ability items</th> </tr> </thead> <tbody> <tr> <td rowspan="9">Alarm function</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>Alarm for occlusion in the ID card frame</td> </tr> <tr> <td>ID card reflective warning</td> </tr> <tr> <td>Blurry picture warning</td> </tr> </tbody> </table> Default interface request frequency limit: 20 times/second
        /// </summary>
        /// <param name="req"><see cref="RecognizeMainlandIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeMainlandIDCardOCRResponse"/></returns>
        public RecognizeMainlandIDCardOCRResponse RecognizeMainlandIDCardOCRSync(RecognizeMainlandIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeMainlandIDCardOCRResponse>(req, "RecognizeMainlandIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Philippine driver's license.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesDrivingLicenseOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesDrivingLicenseOCRResponse"/></returns>
        public Task<RecognizePhilippinesDrivingLicenseOCRResponse> RecognizePhilippinesDrivingLicenseOCR(RecognizePhilippinesDrivingLicenseOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesDrivingLicenseOCRResponse>(req, "RecognizePhilippinesDrivingLicenseOCR");
        }

        /// <summary>
        /// This API is used to recognize a Philippine driver's license.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesDrivingLicenseOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesDrivingLicenseOCRResponse"/></returns>
        public RecognizePhilippinesDrivingLicenseOCRResponse RecognizePhilippinesDrivingLicenseOCRSync(RecognizePhilippinesDrivingLicenseOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesDrivingLicenseOCRResponse>(req, "RecognizePhilippinesDrivingLicenseOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Philippine SSSID/UMID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesSssIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesSssIDOCRResponse"/></returns>
        public Task<RecognizePhilippinesSssIDOCRResponse> RecognizePhilippinesSssIDOCR(RecognizePhilippinesSssIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesSssIDOCRResponse>(req, "RecognizePhilippinesSssIDOCR");
        }

        /// <summary>
        /// This API is used to recognize a Philippine SSSID/UMID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesSssIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesSssIDOCRResponse"/></returns>
        public RecognizePhilippinesSssIDOCRResponse RecognizePhilippinesSssIDOCRSync(RecognizePhilippinesSssIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesSssIDOCRResponse>(req, "RecognizePhilippinesSssIDOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Philippine TIN ID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesTinIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesTinIDOCRResponse"/></returns>
        public Task<RecognizePhilippinesTinIDOCRResponse> RecognizePhilippinesTinIDOCR(RecognizePhilippinesTinIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesTinIDOCRResponse>(req, "RecognizePhilippinesTinIDOCR");
        }

        /// <summary>
        /// This API is used to recognize a Philippine TIN ID card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesTinIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesTinIDOCRResponse"/></returns>
        public RecognizePhilippinesTinIDOCRResponse RecognizePhilippinesTinIDOCRSync(RecognizePhilippinesTinIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesTinIDOCRResponse>(req, "RecognizePhilippinesTinIDOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Philippine Unified Multi-Purpose ID (UMID) card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesUMIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesUMIDOCRResponse"/></returns>
        public Task<RecognizePhilippinesUMIDOCRResponse> RecognizePhilippinesUMIDOCR(RecognizePhilippinesUMIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesUMIDOCRResponse>(req, "RecognizePhilippinesUMIDOCR");
        }

        /// <summary>
        /// This API is used to recognize a Philippine Unified Multi-Purpose ID (UMID) card.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesUMIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesUMIDOCRResponse"/></returns>
        public RecognizePhilippinesUMIDOCRResponse RecognizePhilippinesUMIDOCRSync(RecognizePhilippinesUMIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesUMIDOCRResponse>(req, "RecognizePhilippinesUMIDOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize a Philippine voters ID card. It can recognize fields such as first name, family name, date of birth, civil status, citizenship, address, precinct, and voter's identification number (VIN).
        /// 
        /// The API request rate is limited to 20 requests/sec by default.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesVoteIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesVoteIDOCRResponse"/></returns>
        public Task<RecognizePhilippinesVoteIDOCRResponse> RecognizePhilippinesVoteIDOCR(RecognizePhilippinesVoteIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesVoteIDOCRResponse>(req, "RecognizePhilippinesVoteIDOCR");
        }

        /// <summary>
        /// This API is used to recognize a Philippine voters ID card. It can recognize fields such as first name, family name, date of birth, civil status, citizenship, address, precinct, and voter's identification number (VIN).
        /// 
        /// The API request rate is limited to 20 requests/sec by default.
        /// </summary>
        /// <param name="req"><see cref="RecognizePhilippinesVoteIDOCRRequest"/></param>
        /// <returns><see cref="RecognizePhilippinesVoteIDOCRResponse"/></returns>
        public RecognizePhilippinesVoteIDOCRResponse RecognizePhilippinesVoteIDOCRSync(RecognizePhilippinesVoteIDOCRRequest req)
        {
            return InternalRequestAsync<RecognizePhilippinesVoteIDOCRResponse>(req, "RecognizePhilippinesVoteIDOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface supports the identification of all fields on the front side of ID card for Singapore residents.The identification accuracy reaches more than 99%.In addition, this interface also supports a variety of value-added capabilities to meet the needs of different scenarios. Such as the cropping function of ID card photos and portrait photos, and also has 5 alarm functions.
        /// As shown in the table below. <table style="width:650px"> <thead> <tr> <th width="150">Value-added ability</th> <th width="500">Ability items</th> </tr> </thead> <tbody> <tr> <td rowspan="9">Alarm function</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>Alarm for occlusion in the ID card frame</td> </tr> <tr> <td>ID card reflective warning</td> </tr> <tr> <td>Blurry picture warning</td> </tr> </tbody> </table> Default interface request frequency limit: 20 times/second
        /// </summary>
        /// <param name="req"><see cref="RecognizeSingaporeIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeSingaporeIDCardOCRResponse"/></returns>
        public Task<RecognizeSingaporeIDCardOCRResponse> RecognizeSingaporeIDCardOCR(RecognizeSingaporeIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeSingaporeIDCardOCRResponse>(req, "RecognizeSingaporeIDCardOCR");
        }

        /// <summary>
        /// This interface supports the identification of all fields on the front side of ID card for Singapore residents.The identification accuracy reaches more than 99%.In addition, this interface also supports a variety of value-added capabilities to meet the needs of different scenarios. Such as the cropping function of ID card photos and portrait photos, and also has 5 alarm functions.
        /// As shown in the table below. <table style="width:650px"> <thead> <tr> <th width="150">Value-added ability</th> <th width="500">Ability items</th> </tr> </thead> <tbody> <tr> <td rowspan="9">Alarm function</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>ID card copy warning</td> </tr> <tr> <td>Alarm for occlusion in the ID card frame</td> </tr> <tr> <td>ID card reflective warning</td> </tr> <tr> <td>Blurry picture warning</td> </tr> </tbody> </table> Default interface request frequency limit: 20 times/second
        /// </summary>
        /// <param name="req"><see cref="RecognizeSingaporeIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeSingaporeIDCardOCRResponse"/></returns>
        public RecognizeSingaporeIDCardOCRResponse RecognizeSingaporeIDCardOCRSync(RecognizeSingaporeIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeSingaporeIDCardOCRResponse>(req, "RecognizeSingaporeIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize regular tables, borderless tables, or multi-tables in images or PDF files containing Chinese and English texts. It returns the text content of each cell, supports recognition of rotated table images, and can save the recognition results into an Excel document. It delivers higher recognition accuracy than that of table OCR v2 and applies to more scenarios. The recognition accuracy in difficult table scenarios, such as irregular tables and nested tables (borderless tables contained in bordered tables), is better than that of table OCR v2. To try it, click [here](https://intl.cloud.tencent.com/product/smart?from_cn_redirect=1-ocr).
        /// 
        /// A maximum of 2 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="RecognizeTableAccurateOCRRequest"/></param>
        /// <returns><see cref="RecognizeTableAccurateOCRResponse"/></returns>
        public Task<RecognizeTableAccurateOCRResponse> RecognizeTableAccurateOCR(RecognizeTableAccurateOCRRequest req)
        {
            return InternalRequestAsync<RecognizeTableAccurateOCRResponse>(req, "RecognizeTableAccurateOCR");
        }

        /// <summary>
        /// This API is used to recognize regular tables, borderless tables, or multi-tables in images or PDF files containing Chinese and English texts. It returns the text content of each cell, supports recognition of rotated table images, and can save the recognition results into an Excel document. It delivers higher recognition accuracy than that of table OCR v2 and applies to more scenarios. The recognition accuracy in difficult table scenarios, such as irregular tables and nested tables (borderless tables contained in bordered tables), is better than that of table OCR v2. To try it, click [here](https://intl.cloud.tencent.com/product/smart?from_cn_redirect=1-ocr).
        /// 
        /// A maximum of 2 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="RecognizeTableAccurateOCRRequest"/></param>
        /// <returns><see cref="RecognizeTableAccurateOCRResponse"/></returns>
        public RecognizeTableAccurateOCRResponse RecognizeTableAccurateOCRSync(RecognizeTableAccurateOCRRequest req)
        {
            return InternalRequestAsync<RecognizeTableAccurateOCRResponse>(req, "RecognizeTableAccurateOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize the fields on a Thai identity card, including name in Thai, name in English, address, date of birth, identification number, date of issue, and date of expiry.
        /// Currently, this API is not generally available. For more information, please [contact your sales rep](https://intl.cloud.tencent.com/about/connect?from_cn_redirect=1).
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="RecognizeThaiIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeThaiIDCardOCRResponse"/></returns>
        public Task<RecognizeThaiIDCardOCRResponse> RecognizeThaiIDCardOCR(RecognizeThaiIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeThaiIDCardOCRResponse>(req, "RecognizeThaiIDCardOCR");
        }

        /// <summary>
        /// This API is used to recognize the fields on a Thai identity card, including name in Thai, name in English, address, date of birth, identification number, date of issue, and date of expiry.
        /// Currently, this API is not generally available. For more information, please [contact your sales rep](https://intl.cloud.tencent.com/about/connect?from_cn_redirect=1).
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="RecognizeThaiIDCardOCRRequest"/></param>
        /// <returns><see cref="RecognizeThaiIDCardOCRResponse"/></returns>
        public RecognizeThaiIDCardOCRResponse RecognizeThaiIDCardOCRSync(RecognizeThaiIDCardOCRRequest req)
        {
            return InternalRequestAsync<RecognizeThaiIDCardOCRResponse>(req, "RecognizeThaiIDCardOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize various types of seals, including invoice seals and finance seals. It is suitable for scenarios such as official document and invoice/ticket OCR.
        /// 
        /// A maximum of 5 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SealOCRRequest"/></param>
        /// <returns><see cref="SealOCRResponse"/></returns>
        public Task<SealOCRResponse> SealOCR(SealOCRRequest req)
        {
            return InternalRequestAsync<SealOCRResponse>(req, "SealOCR");
        }

        /// <summary>
        /// This API is used to recognize various types of seals, including invoice seals and finance seals. It is suitable for scenarios such as official document and invoice/ticket OCR.
        /// 
        /// A maximum of 5 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SealOCRRequest"/></param>
        /// <returns><see cref="SealOCRResponse"/></returns>
        public SealOCRResponse SealOCRSync(SealOCRRequest req)
        {
            return InternalRequestAsync<SealOCRResponse>(req, "SealOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize fields from cards, documents, bills, forms, contracts, and other structured information. It is flexible and efficient to use, without any configuration required. This API is suitable for recognizing structured information.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SmartStructuralOCRV2Request"/></param>
        /// <returns><see cref="SmartStructuralOCRV2Response"/></returns>
        public Task<SmartStructuralOCRV2Response> SmartStructuralOCRV2(SmartStructuralOCRV2Request req)
        {
            return InternalRequestAsync<SmartStructuralOCRV2Response>(req, "SmartStructuralOCRV2");
        }

        /// <summary>
        /// This API is used to recognize fields from cards, documents, bills, forms, contracts, and other structured information. It is flexible and efficient to use, without any configuration required. This API is suitable for recognizing structured information.
        /// 
        /// A maximum of 10 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SmartStructuralOCRV2Request"/></param>
        /// <returns><see cref="SmartStructuralOCRV2Response"/></returns>
        public SmartStructuralOCRV2Response SmartStructuralOCRV2Sync(SmartStructuralOCRV2Request req)
        {
            return InternalRequestAsync<SmartStructuralOCRV2Response>(req, "SmartStructuralOCRV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect and recognize Chinese and English forms in images. It can return the text content of each cell and save the recognition result as Excel.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="TableOCRRequest"/></param>
        /// <returns><see cref="TableOCRResponse"/></returns>
        public Task<TableOCRResponse> TableOCR(TableOCRRequest req)
        {
            return InternalRequestAsync<TableOCRResponse>(req, "TableOCR");
        }

        /// <summary>
        /// This API is used to detect and recognize Chinese and English forms in images. It can return the text content of each cell and save the recognition result as Excel.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="TableOCRRequest"/></param>
        /// <returns><see cref="TableOCRResponse"/></returns>
        public TableOCRResponse TableOCRSync(TableOCRRequest req)
        {
            return InternalRequestAsync<TableOCRResponse>(req, "TableOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize the vehicle identification number (VIN) in an image.
        /// </summary>
        /// <param name="req"><see cref="VinOCRRequest"/></param>
        /// <returns><see cref="VinOCRResponse"/></returns>
        public Task<VinOCRResponse> VinOCR(VinOCRRequest req)
        {
            return InternalRequestAsync<VinOCRResponse>(req, "VinOCR");
        }

        /// <summary>
        /// This API is used to recognize the vehicle identification number (VIN) in an image.
        /// </summary>
        /// <param name="req"><see cref="VinOCRRequest"/></param>
        /// <returns><see cref="VinOCRResponse"/></returns>
        public VinOCRResponse VinOCRSync(VinOCRRequest req)
        {
            return InternalRequestAsync<VinOCRResponse>(req, "VinOCR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
