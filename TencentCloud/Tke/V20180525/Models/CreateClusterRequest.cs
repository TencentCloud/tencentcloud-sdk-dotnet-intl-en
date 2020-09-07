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

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// Container networking configuration information for the cluster
        /// </summary>
        [JsonProperty("ClusterCIDRSettings")]
        public ClusterCIDRSettings ClusterCIDRSettings{ get; set; }

        /// <summary>
        /// Cluster type. Managed cluster: MANAGED_CLUSTER; self-deployed cluster: INDEPENDENT_CLUSTER.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Pass-through parameter for CVM creation in the format of a JSON string. For more information, see the API for [creating a CVM instance](https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("RunInstancesForNode")]
        public RunInstancesForNode[] RunInstancesForNode{ get; set; }

        /// <summary>
        /// Basic configuration information of the cluster
        /// </summary>
        [JsonProperty("ClusterBasicSettings")]
        public ClusterBasicSettings ClusterBasicSettings{ get; set; }

        /// <summary>
        /// Advanced configuration information of the cluster
        /// </summary>
        [JsonProperty("ClusterAdvancedSettings")]
        public ClusterAdvancedSettings ClusterAdvancedSettings{ get; set; }

        /// <summary>
        /// Advanced configuration information of the node
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// Configuration information of an existing instance
        /// </summary>
        [JsonProperty("ExistedInstancesForNode")]
        public ExistedInstancesForNode[] ExistedInstancesForNode{ get; set; }

        /// <summary>
        /// CVM type and the corresponding data disk mounting configuration information.
        /// </summary>
        [JsonProperty("InstanceDataDiskMountSettings")]
        public InstanceDataDiskMountSetting[] InstanceDataDiskMountSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClusterCIDRSettings.", this.ClusterCIDRSettings);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArrayObj(map, prefix + "RunInstancesForNode.", this.RunInstancesForNode);
            this.SetParamObj(map, prefix + "ClusterBasicSettings.", this.ClusterBasicSettings);
            this.SetParamObj(map, prefix + "ClusterAdvancedSettings.", this.ClusterAdvancedSettings);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamArrayObj(map, prefix + "ExistedInstancesForNode.", this.ExistedInstancesForNode);
            this.SetParamArrayObj(map, prefix + "InstanceDataDiskMountSettings.", this.InstanceDataDiskMountSettings);
        }
    }
}

