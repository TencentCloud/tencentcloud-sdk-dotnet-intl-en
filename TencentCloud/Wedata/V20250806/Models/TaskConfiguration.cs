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

    public class TaskConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Base64 encoding of the code content.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodeContent")]
        public string CodeContent{ get; set; }

        /// <summary>
        /// Extended attribute configuration list of the task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskExtConfigurationList")]
        public TaskExtParameter[] TaskExtConfigurationList{ get; set; }

        /// <summary>
        /// Cluster ID
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataCluster")]
        public string DataCluster{ get; set; }

        /// <summary>
        /// Specifies the specified running node.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Resource pool queue name. need to pass through DescribeProjectClusterQueues to obtain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// Source data source ID, separated by;, obtained through DescribeDataSourceWithoutInfo.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// Data source type. use semicolon to separate. need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceServiceType")]
        public string SourceServiceType{ get; set; }

        /// <summary>
        /// Data source name. use semicolons to separate. need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceServiceName")]
        public string SourceServiceName{ get; set; }

        /// <summary>
        /// TargetTarget data source ID, separated by semicolons. need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// Target data source type. uses ; for separation. needs to pass through DescribeDataSourceWithoutInfo for retrieval.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// Target data source name. use semicolon to separate. need to pass through DescribeDataSourceWithoutInfo to obtain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetServiceName")]
        public string TargetServiceName{ get; set; }

        /// <summary>
        /// Resource group ID: need to pass through DescribeNormalSchedulerExecutorGroups to obtain ExecutorGroupId.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// Resource group name: need to pass through DescribeNormalSchedulerExecutorGroups to obtain ExecutorGroupName.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// Specifies the scheduling parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskSchedulingParameterList")]
        public TaskSchedulingParameter[] TaskSchedulingParameterList{ get; set; }

        /// <summary>
        /// ID used by the Bundle.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Bundle info.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeContent", this.CodeContent);
            this.SetParamArrayObj(map, prefix + "TaskExtConfigurationList.", this.TaskExtConfigurationList);
            this.SetParamSimple(map, prefix + "DataCluster", this.DataCluster);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "SourceServiceType", this.SourceServiceType);
            this.SetParamSimple(map, prefix + "SourceServiceName", this.SourceServiceName);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceType", this.TargetServiceType);
            this.SetParamSimple(map, prefix + "TargetServiceName", this.TargetServiceName);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamArrayObj(map, prefix + "TaskSchedulingParameterList.", this.TaskSchedulingParameterList);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

