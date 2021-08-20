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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductProperties : AbstractModel
    {
        
        /// <summary>
        /// Product description
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// Authentication type. `1` (default): certificate; `2`: signature
        /// </summary>
        [JsonProperty("EncryptionType")]
        public string EncryptionType{ get; set; }

        /// <summary>
        /// Product region. Valid value: `gz` (Guangzhou)
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Product type. Valid values:
        /// `0` (default): general; `2`: NB-IoT; `3`: LoRa gateway; `4`: LoRa; `5`: general gateway
        /// </summary>
        [JsonProperty("ProductType")]
        public ulong? ProductType{ get; set; }

        /// <summary>
        /// Data format. Valid values: `json` (default), `custom`
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Platform of the product. Default value: `0`
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// AppEUI at the LoRa product operator, required only for LoRa products
        /// </summary>
        [JsonProperty("Appeui")]
        public string Appeui{ get; set; }

        /// <summary>
        /// ID of the Thing Specification Language (TSL) model bound to the product. `-1` means no models are bound.
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// Name of the TSL model bound to the product
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Product key, which is specific to suite products
        /// </summary>
        [JsonProperty("ProductKey")]
        public string ProductKey{ get; set; }

        /// <summary>
        /// Dynamic registration type. `0`: disable; `1`: preset device names; `2`: generate device names dynamically
        /// </summary>
        [JsonProperty("RegisterType")]
        public ulong? RegisterType{ get; set; }

        /// <summary>
        /// Dynamic registration product key
        /// </summary>
        [JsonProperty("ProductSecret")]
        public string ProductSecret{ get; set; }

        /// <summary>
        /// The maximum number of devices that can be dynamically created when `RegisterType` is set to `2`
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public ulong? RegisterLimit{ get; set; }

        /// <summary>
        /// Original product ID of a transferred product. This parameter is empty for products that are not transferred.
        /// </summary>
        [JsonProperty("OriginProductId")]
        public string OriginProductId{ get; set; }

        /// <summary>
        /// Private CA certificate name
        /// </summary>
        [JsonProperty("PrivateCAName")]
        public string PrivateCAName{ get; set; }

        /// <summary>
        /// Original user ID of a transferred product. This parameter is empty for products that are not transferred.
        /// </summary>
        [JsonProperty("OriginUserId")]
        public ulong? OriginUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Appeui", this.Appeui);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ProductKey", this.ProductKey);
            this.SetParamSimple(map, prefix + "RegisterType", this.RegisterType);
            this.SetParamSimple(map, prefix + "ProductSecret", this.ProductSecret);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
            this.SetParamSimple(map, prefix + "OriginProductId", this.OriginProductId);
            this.SetParamSimple(map, prefix + "PrivateCAName", this.PrivateCAName);
            this.SetParamSimple(map, prefix + "OriginUserId", this.OriginUserId);
        }
    }
}

