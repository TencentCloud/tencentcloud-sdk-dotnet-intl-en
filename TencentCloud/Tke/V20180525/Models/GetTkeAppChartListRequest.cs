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

    public class GetTkeAppChartListRequest : AbstractModel
    {
        
        /// <summary>
        /// Type specifies the application category. valid values include log, scheduler, network, storage, monitor, dns, image, other, and invisible.
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Specifies the supported operating systems of the app. valid values: arm32, arm64, amd64.
        /// </summary>
        [JsonProperty("Arch")]
        public string Arch{ get; set; }

        /// <summary>
        /// ClusterType specifies the type of the cluster. valid values are tke and eks.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Arch", this.Arch);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

