/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckIdCardInformationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Base64 value of the ID card portrait side.</p><ul><li>Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported.</li><li>Supported image size: the downloaded image should be no more than 7M after Base64 encoding.</li><li>Please use the standard Base64 encoding method (with = padding). Refer to RFC4648 for coding specification.</li><li>Either ImageBase64 or ImageUrl must be provided. If both are provided, proceed to use parameters according to the priority of ImageUrl > ImageBase64.</li></ul>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>Url address of the ID card portrait side</p><ul><li>Supported image formats: PNG, JPG, JPEG. GIF format is not currently supported.</li><li>Supported image size: The downloaded image after Base64 encoding is no more than 3M. Image download time is no more than 3 seconds.</li><li>Images stored in Tencent Cloud's Url can guarantee higher download speed and stability. It is recommended to store images in Tencent Cloud.</li><li>Speed and stability of non-Tencent Cloud Storage URLs may be impacted to a certain extent.</li></ul>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>Configuration.</p><ul><li><p>All the following optional fields are bool type, default false.<br>CopyWarn, alarm for photocopy.<br>BorderCheckWarn, border and frame block alarm.<br>ReshootWarn, alarm for rephotographing.<br>DetectPsWarn, PS detection alarm (suspected PS traces).<br>TempIdWarn, temporary ID card alarm.<br>Quality, image Quality alarm (evaluates blurriness).</p></li><li><p>SDK configuration method for reference:<br>Config = Json.stringify({"CopyWarn":true,"ReshootWarn":true}).</p></li><li><p>API 3.0 Explorer setting method for reference:<br>Config = {"CopyWarn":true,"ReshootWarn":true}.</p></li></ul>
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// <p>Whether required to encrypt sensitive information in the response.</p><ul><li>Default false.</li><li>Sensitive information includes Response.IdNum and Response.Name.</li></ul>
        /// </summary>
        [JsonProperty("IsEncrypt")]
        public bool? IsEncrypt{ get; set; }

        /// <summary>
        /// <p>Whether required to encrypt the response body.</p>
        /// </summary>
        [JsonProperty("IsEncryptResponse")]
        public bool? IsEncryptResponse{ get; set; }

        /// <summary>
        /// <p>Whether required to encrypt sensitive information in the response, need to be specified encryption algorithm Algorithm, initial vector for CBC encryption, and encrypted symmetric key.</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "IsEncrypt", this.IsEncrypt);
            this.SetParamSimple(map, prefix + "IsEncryptResponse", this.IsEncryptResponse);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

