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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyProductList : AbstractModel
    {
        
        /// <summary>
        /// Policy code.
        /// </summary>
        [JsonProperty("PolicyCode")]
        public string PolicyCode{ get; set; }

        /// <summary>
        /// Product code, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Product name, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// SubProduct code, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// SubProduct name, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// Component type code, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ComponentTypeCode")]
        public string ComponentTypeCode{ get; set; }

        /// <summary>
        /// Component type name, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ComponentTypeName")]
        public string ComponentTypeName{ get; set; }

        /// <summary>
        /// Component code, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Component name, if the return is *, any item under this level is included in the policy product scope.
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// Policy effective date.
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// Policy expiration date.
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyCode", this.PolicyCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "SubProductName", this.SubProductName);
            this.SetParamSimple(map, prefix + "ComponentTypeCode", this.ComponentTypeCode);
            this.SetParamSimple(map, prefix + "ComponentTypeName", this.ComponentTypeName);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
        }
    }
}
