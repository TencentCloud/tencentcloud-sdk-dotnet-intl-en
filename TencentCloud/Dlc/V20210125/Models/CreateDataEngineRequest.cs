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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataEngineRequest : AbstractModel
    {
        
        /// <summary>
        /// The engine type. Valid values: `spark` and `presto`.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// The name of the virtual cluster.
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// The cluster type. Valid values: `spark_private`, `presto_private`, `presto_cu`, and `spark_cu`.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// The billing mode. Valid values: `0` (shared engine), `1` (pay-as-you-go), and `2` (monthly subscription).
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Whether to automatically start the clusters.
        /// </summary>
        [JsonProperty("AutoResume")]
        public bool? AutoResume{ get; set; }

        /// <summary>
        /// The minimum number of clusters.
        /// </summary>
        [JsonProperty("MinClusters")]
        public long? MinClusters{ get; set; }

        /// <summary>
        /// The maximum number of clusters.
        /// </summary>
        [JsonProperty("MaxClusters")]
        public long? MaxClusters{ get; set; }

        /// <summary>
        /// Whether the cluster is the default one.
        /// </summary>
        [JsonProperty("DefaultDataEngine")]
        public bool? DefaultDataEngine{ get; set; }

        /// <summary>
        /// The VPC CIDR block.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// The cluster size.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// The pay mode. Valid value: `0` (postpaid, default) and `1` (prepaid) (currently not available).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// The resource period. For the postpaid mode, the value is 3600 (default); for the prepaid mode, the value must be in the range of 1–120, representing purchasing the resource for 1–120 months.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// The unit of the resource period. Valid values: `s` (default) for the postpaid mode and `m` for the prepaid mode.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// The auto-renewal status of the resource. For the postpaid mode, no renewal is required, and the value is fixed to `0`. For the prepaid mode, valid values are `0` (manual), `1` (auto), and `2` (no renewal). If this parameter is set to `0` for a key account in the prepaid mode, auto-renewal applies. It defaults to `0`.
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// The tags to be set for the resource being created.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Whether to automatically suspend clusters. Valid values: `false` (default, no) and `true` (yes).
        /// </summary>
        [JsonProperty("AutoSuspend")]
        public bool? AutoSuspend{ get; set; }

        /// <summary>
        /// Whether to enable scheduled start and suspension of clusters. Valid values: `0` (disable) and `1` (enable). Note: This policy and the auto-suspension policy are mutually exclusive.
        /// </summary>
        [JsonProperty("CrontabResumeSuspend")]
        public long? CrontabResumeSuspend{ get; set; }

        /// <summary>
        /// The complex policy for scheduled start and suspension, including the start/suspension time and suspension policy.
        /// </summary>
        [JsonProperty("CrontabResumeSuspendStrategy")]
        public CrontabResumeSuspendStrategy CrontabResumeSuspendStrategy{ get; set; }

        /// <summary>
        /// The type of tasks to be executed by the engine, which defaults to SQL.
        /// </summary>
        [JsonProperty("EngineExecType")]
        public string EngineExecType{ get; set; }

        /// <summary>
        /// The max task concurrency of a cluster, which defaults to 5.
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// The task queue time limit, which defaults to 0. When the actual queue time exceeds the value set here, scale-out may be triggered. Setting this parameter to 0 represents that scale-out may be triggered immediately after a task queues up.
        /// </summary>
        [JsonProperty("TolerableQueueTime")]
        public long? TolerableQueueTime{ get; set; }

        /// <summary>
        /// The cluster auto-suspension time, which defaults to 10 min.
        /// </summary>
        [JsonProperty("AutoSuspendTime")]
        public long? AutoSuspendTime{ get; set; }

        /// <summary>
        /// The resource type. Valid values: `Standard_CU` (standard) and `Memory_CU` (memory).
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// The advanced configurations of clusters.
        /// </summary>
        [JsonProperty("DataEngineConfigPairs")]
        public DataEngineConfigPair[] DataEngineConfigPairs{ get; set; }

        /// <summary>
        /// The version name of cluster image, such as SuperSQL-P 1.1 and SuperSQL-S 3.2. If no value is passed in, a cluster is created using the latest image version.
        /// </summary>
        [JsonProperty("ImageVersionName")]
        public string ImageVersionName{ get; set; }

        /// <summary>
        /// The name of the primary cluster.
        /// </summary>
        [JsonProperty("MainClusterName")]
        public string MainClusterName{ get; set; }

        /// <summary>
        /// Whether to enable the scaling feature for a monthly subscribed Spark job cluster.
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public bool? ElasticSwitch{ get; set; }

        /// <summary>
        /// The upper limit (in CUs) for scaling of the monthly subscribed Spark job cluster.
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public long? ElasticLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "AutoResume", this.AutoResume);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "DefaultDataEngine", this.DefaultDataEngine);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSuspend", this.AutoSuspend);
            this.SetParamSimple(map, prefix + "CrontabResumeSuspend", this.CrontabResumeSuspend);
            this.SetParamObj(map, prefix + "CrontabResumeSuspendStrategy.", this.CrontabResumeSuspendStrategy);
            this.SetParamSimple(map, prefix + "EngineExecType", this.EngineExecType);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "AutoSuspendTime", this.AutoSuspendTime);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamArrayObj(map, prefix + "DataEngineConfigPairs.", this.DataEngineConfigPairs);
            this.SetParamSimple(map, prefix + "ImageVersionName", this.ImageVersionName);
            this.SetParamSimple(map, prefix + "MainClusterName", this.MainClusterName);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
        }
    }
}

