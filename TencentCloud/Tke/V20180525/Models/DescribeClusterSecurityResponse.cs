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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterSecurityResponse : AbstractModel
    {
        
        /// <summary>
        /// Cluster’s account name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Cluster’s password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Cluster’s access CA certificate
        /// </summary>
        [JsonProperty("CertificationAuthority")]
        public string CertificationAuthority{ get; set; }

        /// <summary>
        /// Cluster’s access address
        /// </summary>
        [JsonProperty("ClusterExternalEndpoint")]
        public string ClusterExternalEndpoint{ get; set; }

        /// <summary>
        /// Domain name accessed by the cluster
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Cluster’s endpoint address
        /// </summary>
        [JsonProperty("PgwEndpoint")]
        public string PgwEndpoint{ get; set; }

        /// <summary>
        /// Cluster’s access policy group
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public string[] SecurityPolicy{ get; set; }

        /// <summary>
        /// Cluster Kubeconfig file
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Kubeconfig")]
        public string Kubeconfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("JnsGwEndpoint")]
        public string JnsGwEndpoint{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "CertificationAuthority", this.CertificationAuthority);
            this.SetParamSimple(map, prefix + "ClusterExternalEndpoint", this.ClusterExternalEndpoint);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "PgwEndpoint", this.PgwEndpoint);
            this.SetParamArraySimple(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
            this.SetParamSimple(map, prefix + "Kubeconfig", this.Kubeconfig);
            this.SetParamSimple(map, prefix + "JnsGwEndpoint", this.JnsGwEndpoint);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

