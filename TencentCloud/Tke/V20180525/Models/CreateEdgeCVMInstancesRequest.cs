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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEdgeCVMInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID. Edge clusters need to enable public network access before adding CVM nodes.
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// Pass-through parameter for CVM creation in the format of a JSON string. To ensure the idempotency of requests for adding cluster nodes, you need to add the `ClientToken` field in this parameter. For more information, see the documentation for [RunInstances](https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("RunInstancePara")]
        public string RunInstancePara{ get; set; }

        /// <summary>
        /// Region of the CVM instances to create
        /// </summary>
        [JsonProperty("CvmRegion")]
        public string CvmRegion{ get; set; }

        /// <summary>
        /// Quantity of CVM instances to create
        /// </summary>
        [JsonProperty("CvmCount")]
        public long? CvmCount{ get; set; }

        /// <summary>
        /// Instance extension information
        /// </summary>
        [JsonProperty("External")]
        public string External{ get; set; }

        /// <summary>
        /// Custom script
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// Whether to enable ENI
        /// </summary>
        [JsonProperty("EnableEni")]
        public bool? EnableEni{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "RunInstancePara", this.RunInstancePara);
            this.SetParamSimple(map, prefix + "CvmRegion", this.CvmRegion);
            this.SetParamSimple(map, prefix + "CvmCount", this.CvmCount);
            this.SetParamSimple(map, prefix + "External", this.External);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamSimple(map, prefix + "EnableEni", this.EnableEni);
        }
    }
}

