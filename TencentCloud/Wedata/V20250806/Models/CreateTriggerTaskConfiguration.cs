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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTriggerTaskConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Resource group ID: need to pass through DescribeNormalSchedulerExecutorGroups to obtain ExecutorGroupId.
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// Base64 encoding of the code content.
        /// </summary>
        [JsonProperty("CodeContent")]
        public string CodeContent{ get; set; }

        /// <summary>
        /// Task extended attribute configuration list.
        /// </summary>
        [JsonProperty("TaskExtConfigurationList")]
        public TaskExtParameter[] TaskExtConfigurationList{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("DataCluster")]
        public string DataCluster{ get; set; }

        /// <summary>
        /// Specified running node.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Resource pool queue name. need to pass through DescribeProjectClusterQueues to obtain.
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// Source data source ID, separated by semicolons, need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// Target data source ID, use ; to separate, need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// Scheduling parameter.
        /// </summary>
        [JsonProperty("TaskSchedulingParameterList")]
        public TaskSchedulingParameter[] TaskSchedulingParameterList{ get; set; }

        /// <summary>
        /// ID used by the Bundle.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Bundle info.
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "CodeContent", this.CodeContent);
            this.SetParamArrayObj(map, prefix + "TaskExtConfigurationList.", this.TaskExtConfigurationList);
            this.SetParamSimple(map, prefix + "DataCluster", this.DataCluster);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamArrayObj(map, prefix + "TaskSchedulingParameterList.", this.TaskSchedulingParameterList);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

