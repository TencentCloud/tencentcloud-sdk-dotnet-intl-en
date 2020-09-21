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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LayerVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// Runtime applicable to a version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompatibleRuntimes")]
        public string[] CompatibleRuntimes{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Version description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// License information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LicenseInfo")]
        public string LicenseInfo{ get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [JsonProperty("LayerVersion")]
        public long? LayerVersion{ get; set; }

        /// <summary>
        /// Layer name
        /// </summary>
        [JsonProperty("LayerName")]
        public string LayerName{ get; set; }

        /// <summary>
        /// Current status of specific layer version. For valid values, please see [here](https://intl.cloud.tencent.com/document/product/583/47175?from_cn_redirect=1#.E5.B1.82.EF.BC.88layer.EF.BC.89.E7.8A.B6.E6.80.81)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CompatibleRuntimes.", this.CompatibleRuntimes);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LicenseInfo", this.LicenseInfo);
            this.SetParamSimple(map, prefix + "LayerVersion", this.LayerVersion);
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

