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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CostAnalyzeFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>Contains product code</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessIn")]
        public string[] BusinessIn{ get; set; }

        /// <summary>
        /// <p>Contains sub-product code</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductIn")]
        public string[] ProductIn{ get; set; }

        /// <summary>
        /// <p>Contains region id</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionIn")]
        public string[] RegionIn{ get; set; }

        /// <summary>
        /// <p>Contains transaction type</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionTypeIn")]
        public string[] ActionTypeIn{ get; set; }

        /// <summary>
        /// <p>Includes payment mode</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayModeIn")]
        public string[] PayModeIn{ get; set; }

        /// <summary>
        /// <p>Include project name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectIn")]
        public string[] ProjectIn{ get; set; }

        /// <summary>
        /// <p>Contains payer uin</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayerUinIn")]
        public string[] PayerUinIn{ get; set; }

        /// <summary>
        /// <p>Tag key.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// <p>Tag value list</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagIn")]
        public string[] TagIn{ get; set; }

        /// <summary>
        /// <p>Contains availability zones</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneIn")]
        public string[] ZoneIn{ get; set; }

        /// <summary>
        /// <p>Owner uin</p>
        /// </summary>
        [JsonProperty("OwnerUinIn")]
        public string[] OwnerUinIn{ get; set; }

        /// <summary>
        /// <p>Component type info</p>
        /// </summary>
        [JsonProperty("ComponentIn")]
        public string[] ComponentIn{ get; set; }

        /// <summary>
        /// <p>Component name</p>
        /// </summary>
        [JsonProperty("ItemIn")]
        public string[] ItemIn{ get; set; }

        /// <summary>
        /// <p>Resource id information</p>
        /// </summary>
        [JsonProperty("ResourceIn")]
        public string[] ResourceIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BusinessIn.", this.BusinessIn);
            this.SetParamArraySimple(map, prefix + "ProductIn.", this.ProductIn);
            this.SetParamArraySimple(map, prefix + "RegionIn.", this.RegionIn);
            this.SetParamArraySimple(map, prefix + "ActionTypeIn.", this.ActionTypeIn);
            this.SetParamArraySimple(map, prefix + "PayModeIn.", this.PayModeIn);
            this.SetParamArraySimple(map, prefix + "ProjectIn.", this.ProjectIn);
            this.SetParamArraySimple(map, prefix + "PayerUinIn.", this.PayerUinIn);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamArraySimple(map, prefix + "TagIn.", this.TagIn);
            this.SetParamArraySimple(map, prefix + "ZoneIn.", this.ZoneIn);
            this.SetParamArraySimple(map, prefix + "OwnerUinIn.", this.OwnerUinIn);
            this.SetParamArraySimple(map, prefix + "ComponentIn.", this.ComponentIn);
            this.SetParamArraySimple(map, prefix + "ItemIn.", this.ItemIn);
            this.SetParamArraySimple(map, prefix + "ResourceIn.", this.ResourceIn);
        }
    }
}

