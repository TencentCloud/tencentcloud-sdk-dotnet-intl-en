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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PromotionCode : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the promotion code</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>The type of the promotion code, for example: qrcode, barcode, miniprogram code</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>The url or hyperlink to the image</p>
        /// </summary>
        [JsonProperty("ImageLink")]
        public string ImageLink{ get; set; }

        /// <summary>
        /// <p>The address where the promotion code worked</p>
        /// </summary>
        [JsonProperty("Address")]
        public Address Address{ get; set; }

        /// <summary>
        /// <p>The item(s) associated with the promotion code</p>
        /// </summary>
        [JsonProperty("Items")]
        public Item[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ImageLink", this.ImageLink);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

