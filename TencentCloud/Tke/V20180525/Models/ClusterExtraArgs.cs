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

    public class ClusterExtraArgs : AbstractModel
    {
        
        /// <summary>
        /// kube-apiserver custom parameter, in the format of ["k1=v1", "k1=v2"], for example: ["max-requests-inflight=500","feature-gates=PodShareProcessNamespace=true,DynamicKubeletConfig=true"].
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("KubeAPIServer")]
        public string[] KubeAPIServer{ get; set; }

        /// <summary>
        /// kube-controller-manager custom parameter
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("KubeControllerManager")]
        public string[] KubeControllerManager{ get; set; }

        /// <summary>
        /// kube-scheduler custom parameter
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("KubeScheduler")]
        public string[] KubeScheduler{ get; set; }

        /// <summary>
        /// etcd custom parameter, which is only effective for self-deployed cluster.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Etcd")]
        public string[] Etcd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "KubeAPIServer.", this.KubeAPIServer);
            this.SetParamArraySimple(map, prefix + "KubeControllerManager.", this.KubeControllerManager);
            this.SetParamArraySimple(map, prefix + "KubeScheduler.", this.KubeScheduler);
            this.SetParamArraySimple(map, prefix + "Etcd.", this.Etcd);
        }
    }
}

