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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetLayerVersionResponse : AbstractModel
    {
        
        /// <summary>
        /// Compatible runtimes
        /// </summary>
        [JsonProperty("CompatibleRuntimes")]
        public string[] CompatibleRuntimes{ get; set; }

        /// <summary>
        /// SHA256 encoding of version file on the layer
        /// </summary>
        [JsonProperty("CodeSha256")]
        public string CodeSha256{ get; set; }

        /// <summary>
        /// Download address of version file on the layer
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Version creation time
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Version description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// License information
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
        /// Current status of specific layer version. For the status values, [see here](https://intl.cloud.tencent.com/document/product/583/47175?from_cn_redirect=1#.E5.B1.82.EF.BC.88layer.EF.BC.89.E7.8A.B6.E6.80.81)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CompatibleRuntimes.", this.CompatibleRuntimes);
            this.SetParamSimple(map, prefix + "CodeSha256", this.CodeSha256);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LicenseInfo", this.LicenseInfo);
            this.SetParamSimple(map, prefix + "LayerVersion", this.LayerVersion);
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

