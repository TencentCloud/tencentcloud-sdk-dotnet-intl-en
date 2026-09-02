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

    public class DescribeClusterInstallCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether it is Tencent Cloud. true: use the parallel container daemonset yaml installation branch; false: use the host agent installation command branch</p>
        /// </summary>
        [JsonProperty("IsCloud")]
        public bool? IsCloud{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Network type<br>Enumeration values:<br>basic: basic network<br>private: VPC<br>public: public network<br>direct: direct connect</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>Region code (required when NetType=direct; used by the Tencent Cloud branch for special region mirror repository replacement)</p>
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// <p>VPC ID (required when NetType=direct)<br>Parameter format: in the form of vpc-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Expiration time<br>Parameter format: yyyy-MM-dd (for example, 2026-12-31)<br>Purpose: For the Tencent Cloud branch, it is the expiration time of the cos download link for the daemonset yaml; for the non-Tencent Cloud branch, it is the expiration time of the agent installation token</p>
        /// </summary>
        [JsonProperty("ExpireDate")]
        public string ExpireDate{ get; set; }

        /// <summary>
        /// <p>List of csip tag IDs (for non-Tencent Cloud branches, associate installation tags)</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }

        /// <summary>
        /// <p>Cluster custom parameters (Tencent Cloud branch used for replacing daemonset template placeholders)</p>
        /// </summary>
        [JsonProperty("ClusterCustomParameters")]
        public ClusterCustomParameters[] ClusterCustomParameters{ get; set; }

        /// <summary>
        /// <p>Integration VIP (used by non-Tenant Cloud branches; automatically applied for by the DC service when NetType=direct and Vip is not passed)</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ExpireDate", this.ExpireDate);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArrayObj(map, prefix + "ClusterCustomParameters.", this.ClusterCustomParameters);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

