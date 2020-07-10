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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to detect and recognize key fields such as the card number, bank information, and expiration date on mainstream bank cards in Mainland China.
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public async Task<BankCardOCRResponse> BankCardOCR(BankCardOCRRequest req)
        {
             JsonResponseModel<BankCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect and recognize key fields such as the card number, bank information, and expiration date on mainstream bank cards in Mainland China.
        /// </summary>
        /// <param name="req"><see cref="BankCardOCRRequest"/></param>
        /// <returns><see cref="BankCardOCRResponse"/></returns>
        public BankCardOCRResponse BankCardOCRSync(BankCardOCRRequest req)
        {
             JsonResponseModel<BankCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image in the following 19 languages: Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, and Thai. Mixed characters in English and each supported language can be recognized together.
        /// 
        /// It can recognize printed text in paper documents, online images, ads, signboards, menus, video titles, profile photos, etc.
        /// 
        /// Product strengths: it can automatically recognize the text language, return the text box coordinate information, and automatically rotate tilted text to the upright direction.
        /// 
        /// The differences between different editions of general print recognition are as detailed below:
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th style="width:200px">**(Recommended)** General Print Recognition</th>
        ///           <th ><a href="https://cloud.tencent.com/document/product/866/34937">**(Recommended)** General Print Recognition (High-Precision)</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">General Print Recognition (Simplified)</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td>Use case</td>
        ///           <td>It is suitable for recognition of printed text in all general scenarios</td>
        ///           <td>It is suitable for content with high recognition difficulty such as a large number of characters, long strings of digits, small characters, blurry characters, and tilted text</td>
        ///           <td>It is suitable for fast text recognition, which compromises the accuracy and recall rate but is more cost-effective</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Recognition accuracy rate</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Price</td>
        ///           <td>Medium</td>
        ///           <td>High</td>
        ///           <td>Low</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Supported languages</td>
        ///           <td>Chinese, English, Chinese-English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, and Thai</td>
        ///           <td>Chinese, English, and Chinese-English</td>
        ///           <td>Chinese, English, and Chinese-English</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Automatic language detection</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Return of text line coordinates</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Automatic rotation correction</td>
        ///           <td>Rotation recognition is supported, and the angle information can be returned</td>
        ///           <td>Rotation recognition is supported, but no angle information can be returned</td>
        ///           <td>Rotation recognition is supported, and the angle information can be returned</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public async Task<GeneralBasicOCRResponse> GeneralBasicOCR(GeneralBasicOCRRequest req)
        {
             JsonResponseModel<GeneralBasicOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralBasicOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralBasicOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect and recognize characters in an image in the following 19 languages: Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, and Thai. Mixed characters in English and each supported language can be recognized together.
        /// 
        /// It can recognize printed text in paper documents, online images, ads, signboards, menus, video titles, profile photos, etc.
        /// 
        /// Product strengths: it can automatically recognize the text language, return the text box coordinate information, and automatically rotate tilted text to the upright direction.
        /// 
        /// The differences between different editions of general print recognition are as detailed below:
        /// <table style="width:715px">
        ///       <thead>
        ///         <tr>
        ///           <th style="width:150px"></th>
        ///           <th style="width:200px">**(Recommended)** General Print Recognition</th>
        ///           <th ><a href="https://cloud.tencent.com/document/product/866/34937">**(Recommended)** General Print Recognition (High-Precision)</a></th>
        ///           <th><a href="https://cloud.tencent.com/document/product/866/37831">General Print Recognition (Simplified)</a></th>
        ///         </tr>
        ///       </thead>
        ///       <tbody>
        ///         <tr>
        ///           <td>Use case</td>
        ///           <td>It is suitable for recognition of printed text in all general scenarios</td>
        ///           <td>It is suitable for content with high recognition difficulty such as a large number of characters, long strings of digits, small characters, blurry characters, and tilted text</td>
        ///           <td>It is suitable for fast text recognition, which compromises the accuracy and recall rate but is more cost-effective</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Recognition accuracy rate</td>
        ///           <td>96%</td>
        ///           <td>99%</td>
        ///           <td>91%</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Price</td>
        ///           <td>Medium</td>
        ///           <td>High</td>
        ///           <td>Low</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Supported languages</td>
        ///           <td>Chinese, English, Chinese-English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, and Thai</td>
        ///           <td>Chinese, English, and Chinese-English</td>
        ///           <td>Chinese, English, and Chinese-English</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Automatic language detection</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Return of text line coordinates</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///           <td>Supported</td>
        ///         </tr>
        ///         <tr>
        ///           <td>Automatic rotation correction</td>
        ///           <td>Rotation recognition is supported, and the angle information can be returned</td>
        ///           <td>Rotation recognition is supported, but no angle information can be returned</td>
        ///           <td>Rotation recognition is supported, and the angle information can be returned</td>
        ///         </tr>
        ///       </tbody>
        ///     </table>
        /// </summary>
        /// <param name="req"><see cref="GeneralBasicOCRRequest"/></param>
        /// <returns><see cref="GeneralBasicOCRResponse"/></returns>
        public GeneralBasicOCRResponse GeneralBasicOCRSync(GeneralBasicOCRRequest req)
        {
             JsonResponseModel<GeneralBasicOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralBasicOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralBasicOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize a Malaysian identity card. Recognizable fields include identity card number, name, gender, and address. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://cloud.tencent.com/about/connect).
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public async Task<MLIDCardOCRResponse> MLIDCardOCR(MLIDCardOCRRequest req)
        {
             JsonResponseModel<MLIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MLIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize a Malaysian identity card. Recognizable fields include identity card number, name, gender, and address. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://cloud.tencent.com/about/connect).
        /// </summary>
        /// <param name="req"><see cref="MLIDCardOCRRequest"/></param>
        /// <returns><see cref="MLIDCardOCRResponse"/></returns>
        public MLIDCardOCRResponse MLIDCardOCRSync(MLIDCardOCRRequest req)
        {
             JsonResponseModel<MLIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MLIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize a passport issued outside Mainland China. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for spoofed or photocopied documents.
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://cloud.tencent.com/about/connect).
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public async Task<MLIDPassportOCRResponse> MLIDPassportOCR(MLIDPassportOCRRequest req)
        {
             JsonResponseModel<MLIDPassportOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MLIDPassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDPassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize a passport issued outside Mainland China. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for spoofed or photocopied documents.
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://cloud.tencent.com/about/connect).
        /// </summary>
        /// <param name="req"><see cref="MLIDPassportOCRRequest"/></param>
        /// <returns><see cref="MLIDPassportOCRResponse"/></returns>
        public MLIDPassportOCRResponse MLIDPassportOCRSync(MLIDPassportOCRRequest req)
        {
             JsonResponseModel<MLIDPassportOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MLIDPassportOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MLIDPassportOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
