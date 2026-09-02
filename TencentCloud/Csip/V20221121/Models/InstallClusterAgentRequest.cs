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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallClusterAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>cluster CA certificate MD5 list (single/batch unified)<br>Purpose: specify the cluster where the container security Agent needs to be installed (parallel container method)<br>Value reference: obtain it through the ClusterCaMD5 field in the response of the DescribeClusterListV2 API<br>Description: The capi layer does not verify the existence or type of this field. It passes it through to the access side ClusterInstall RPC as cluster_CA_MD5</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5List")]
        public string[] ClusterCaMD5List{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterCaMD5List.", this.ClusterCaMD5List);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

