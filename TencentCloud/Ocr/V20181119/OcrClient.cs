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
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
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
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
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
        public async Task<GeneralAccurateOCRResponse> GeneralAccurateOCR(GeneralAccurateOCRRequest req)
        {
             JsonResponseModel<GeneralAccurateOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GeneralAccurateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralAccurateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<GeneralAccurateOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GeneralAccurateOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GeneralAccurateOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// This API is used to recognize key fields on the photo side of a Hong Kong (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. It can check for card authenticity and crop the identity photo.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public async Task<HKIDCardOCRResponse> HKIDCardOCR(HKIDCardOCRRequest req)
        {
             JsonResponseModel<HKIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HKIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HKIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize key fields on the photo side of a Hong Kong (China) identity card, including name in Chinese, name in English, telecode for name, date of birth, gender, document symbol, date of the first issue, date of the last receipt, identity card number, and permanent residency attribute. It can check for card authenticity and crop the identity photo.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="HKIDCardOCRRequest"/></param>
        /// <returns><see cref="HKIDCardOCRResponse"/></returns>
        public HKIDCardOCRResponse HKIDCardOCRSync(HKIDCardOCRRequest req)
        {
             JsonResponseModel<HKIDCardOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HKIDCardOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HKIDCardOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize a passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
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
        /// This API is used to recognize a passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions. Recognizable fields include passport ID, name, date of birth, gender, expiration date, issuing country/region, and nationality. It has the features of cropping identity photos and alarming for photographed or photocopied documents.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
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

        /// <summary>
        /// This API is used to detect and recognize Chinese and English forms in images. It can return the text content of each cell and save the recognition result as Excel.
        /// 
        /// This API is not fully available for the time being. For more information, please contact your [Tencent Cloud sales rep](https://intl.cloud.tencent.com/contact-sales).
        /// </summary>
        /// <param name="req"><see cref="TableOCRRequest"/></param>
        /// <returns><see cref="TableOCRResponse"/></returns>
        public async Task<TableOCRResponse> TableOCR(TableOCRRequest req)
        {
             JsonResponseModel<TableOCRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<TableOCRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TableOCR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TableOCRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
