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

    public class ExistedInstancesForNode : AbstractModel
    {
        
        /// <summary>
        /// Node role. Values: MASTER_ETCD, WORKER. You only need to specify MASTER_ETCD when creating a self-deployed cluster (INDEPENDENT_CLUSTER).
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// Reinstallation parameter of existing instances
        /// </summary>
        [JsonProperty("ExistedInstancesPara")]
        public ExistedInstancesPara ExistedInstancesPara{ get; set; }

        /// <summary>
        /// Advanced node setting, which overrides the InstanceAdvancedSettings item set at the cluster level (currently valid for the ExtraArgs node custom parameter only)
        /// </summary>
        [JsonProperty("InstanceAdvancedSettingsOverride")]
        public InstanceAdvancedSettings InstanceAdvancedSettingsOverride{ get; set; }

        /// <summary>
        /// When the custom PodCIDR mode is enabled for the cluster, you can specify the maximum number of pods per node.
        /// </summary>
        [JsonProperty("DesiredPodNumbers")]
        public long?[] DesiredPodNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamObj(map, prefix + "ExistedInstancesPara.", this.ExistedInstancesPara);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettingsOverride.", this.InstanceAdvancedSettingsOverride);
            this.SetParamArraySimple(map, prefix + "DesiredPodNumbers.", this.DesiredPodNumbers);
        }
    }
}

