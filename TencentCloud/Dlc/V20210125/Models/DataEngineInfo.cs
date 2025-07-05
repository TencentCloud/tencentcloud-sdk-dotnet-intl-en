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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataEngineInfo : AbstractModel
    {
        
        /// <summary>
        /// DataEngine name
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Engine type: spark/presto
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// Cluster resource type spark_private/presto_private/presto_cu/spark_cu
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Quota ID
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// Data engine status -2 deleted, -1 failed, 0 initializing, 1 suspended, 2 running, 3 ready to delete, and 4 deleting
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Cluster specifications
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// Billing mode: 0 shared mode, 1 pay-as-you-go, and 2 monthly subscription
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Minimum number of clusters
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MinClusters")]
        public long? MinClusters{ get; set; }

        /// <summary>
        /// Maximum number of clusters
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MaxClusters")]
        public long? MaxClusters{ get; set; }

        /// <summary>
        /// Whether to recover automatically
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AutoResume")]
        public bool? AutoResume{ get; set; }

        /// <summary>
        /// Automatic recovery time
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SpendAfter")]
        public long? SpendAfter{ get; set; }

        /// <summary>
        /// Cluster IP range
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// Whether it is the default engine
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DefaultDataEngine")]
        public bool? DefaultDataEngine{ get; set; }

        /// <summary>
        /// Returned Message
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Engine ID
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Isolation time
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// Rectification time
        /// </summary>
        [JsonProperty("ReversalTime")]
        public string ReversalTime{ get; set; }

        /// <summary>
        /// Username
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// Key-value pair collection
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// Permissions owned by the engine
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// Whether to automatically suspend the cluster: False (by default) means that the cluster is not automatically suspended; true means that the cluster is automatically suspended.
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AutoSuspend")]
        public bool? AutoSuspend{ get; set; }

        /// <summary>
        /// Scheduling policy of starting and ending the cluster: 0 (by default) indicates turning off the scheduling policy; 1 indicates turning on the scheduling policy. (Note: The scheduling policy of starting and ending the cluster and the automatic suspension policy are mutually exclusive.)
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CrontabResumeSuspend")]
        public long? CrontabResumeSuspend{ get; set; }

        /// <summary>
        /// Scheduled start and end policy. Complex type: Include start and end time and the cluster suspension strategy.
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CrontabResumeSuspendStrategy")]
        public CrontabResumeSuspendStrategy CrontabResumeSuspendStrategy{ get; set; }

        /// <summary>
        /// Type of the task executed by the engine. Valid value: SQL/BATCH
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineExecType")]
        public string EngineExecType{ get; set; }

        /// <summary>
        /// Automatic renewal flag: 0 means the initial state and there is no automatic renewal by default. If the user has the privilege to retain services with advanced payment, there will be an automatic renewal. 1 means that there is an automatic renewal. 2 means that there is surely no automatic renewal.
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Cluster automatic suspension time
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AutoSuspendTime")]
        public long? AutoSuspendTime{ get; set; }

        /// <summary>
        /// Network connection configuration
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("NetworkConnectionSet")]
        public NetworkConnection[] NetworkConnectionSet{ get; set; }

        /// <summary>
        /// Jump address of ui
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UiURL")]
        public string UiURL{ get; set; }

        /// <summary>
        /// Type of the engine resource
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Cluster image version ID
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ImageVersionId")]
        public string ImageVersionId{ get; set; }

        /// <summary>
        /// Minor cluster image version ID
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// Cluster image version name
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ImageVersionName")]
        public string ImageVersionName{ get; set; }

        /// <summary>
        /// Whether to enable the standby cluster
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("StartStandbyCluster")]
        public bool? StartStandbyCluster{ get; set; }

        /// <summary>
        /// Whether the elastic scaling of the spark jar monthly subscription cluster is enabled
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public bool? ElasticSwitch{ get; set; }

        /// <summary>
        /// Upper limit of the spark jar's monthly subscribed cluster elasticity
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public long? ElasticLimit{ get; set; }

        /// <summary>
        /// Whether it is the default engine
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DefaultHouse")]
        public bool? DefaultHouse{ get; set; }

        /// <summary>
        /// Maximum concurrency number of a single cluster
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// Maximum time for the task to queue
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("TolerableQueueTime")]
        public long? TolerableQueueTime{ get; set; }

        /// <summary>
        /// User AppID
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UserAppId")]
        public long? UserAppId{ get; set; }

        /// <summary>
        /// User uin
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// SessionResourceTemplate
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SessionResourceTemplate")]
        public SessionResourceTemplate SessionResourceTemplate{ get; set; }

        /// <summary>
        /// Automatic authorization switch
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AutoAuthorization")]
        public bool? AutoAuthorization{ get; set; }

        /// <summary>
        /// Engine version, supporting Native/SuperSQL
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineGeneration")]
        public string EngineGeneration{ get; set; }

        /// <summary>
        /// Detailed engine type, supporting SparkSQL/SparkBatch/PrestoSQL/Kyuubi
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineTypeDetail")]
        public string EngineTypeDetail{ get; set; }

        /// <summary>
        /// Engine network ID
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// Number of resource groups associated with the standard engine
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineResourceGroupCount")]
        public long? EngineResourceGroupCount{ get; set; }

        /// <summary>
        /// Current usage of the engine (Cu)
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineResourceUsedCU")]
        public long? EngineResourceUsedCU{ get; set; }

        /// <summary>
        /// Access information of the engine
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AccessInfos")]
        public AccessInfo[] AccessInfos{ get; set; }

        /// <summary>
        /// Name of the network where the engine is located
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EngineNetworkName")]
        public string EngineNetworkName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "AutoResume", this.AutoResume);
            this.SetParamSimple(map, prefix + "SpendAfter", this.SpendAfter);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "DefaultDataEngine", this.DefaultDataEngine);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ReversalTime", this.ReversalTime);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "AutoSuspend", this.AutoSuspend);
            this.SetParamSimple(map, prefix + "CrontabResumeSuspend", this.CrontabResumeSuspend);
            this.SetParamObj(map, prefix + "CrontabResumeSuspendStrategy.", this.CrontabResumeSuspendStrategy);
            this.SetParamSimple(map, prefix + "EngineExecType", this.EngineExecType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "AutoSuspendTime", this.AutoSuspendTime);
            this.SetParamArrayObj(map, prefix + "NetworkConnectionSet.", this.NetworkConnectionSet);
            this.SetParamSimple(map, prefix + "UiURL", this.UiURL);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ImageVersionId", this.ImageVersionId);
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamSimple(map, prefix + "ImageVersionName", this.ImageVersionName);
            this.SetParamSimple(map, prefix + "StartStandbyCluster", this.StartStandbyCluster);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamSimple(map, prefix + "DefaultHouse", this.DefaultHouse);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "UserAppId", this.UserAppId);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamObj(map, prefix + "SessionResourceTemplate.", this.SessionResourceTemplate);
            this.SetParamSimple(map, prefix + "AutoAuthorization", this.AutoAuthorization);
            this.SetParamSimple(map, prefix + "EngineGeneration", this.EngineGeneration);
            this.SetParamSimple(map, prefix + "EngineTypeDetail", this.EngineTypeDetail);
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamSimple(map, prefix + "EngineResourceGroupCount", this.EngineResourceGroupCount);
            this.SetParamSimple(map, prefix + "EngineResourceUsedCU", this.EngineResourceUsedCU);
            this.SetParamArrayObj(map, prefix + "AccessInfos.", this.AccessInfos);
            this.SetParamSimple(map, prefix + "EngineNetworkName", this.EngineNetworkName);
        }
    }
}

