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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamedComputeEnv : AbstractModel
    {
        
        /// <summary>
        /// Compute environment name
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// Number of desired compute nodes
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public long? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// Compute environment description
        /// </summary>
        [JsonProperty("EnvDescription")]
        public string EnvDescription{ get; set; }

        /// <summary>
        /// Compute environment management type
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// Compute environment's specific parameters
        /// </summary>
        [JsonProperty("EnvData")]
        public EnvData EnvData{ get; set; }

        /// <summary>
        /// Data disk mounting option
        /// </summary>
        [JsonProperty("MountDataDisks")]
        public MountDataDisk[] MountDataDisks{ get; set; }

        /// <summary>
        /// Authorization information
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// Input mapping information
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// Agent running mode; applicable for Windows
        /// </summary>
        [JsonProperty("AgentRunningMode")]
        public AgentRunningMode AgentRunningMode{ get; set; }

        /// <summary>
        /// Notification information
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// Policy for inactive nodes. Default: `RECREATE`, which means that instance resources will be re-created periodically for compute nodes where instance creation fails or is abnormally returned.
        /// </summary>
        [JsonProperty("ActionIfComputeNodeInactive")]
        public string ActionIfComputeNodeInactive{ get; set; }

        /// <summary>
        /// When the instances are failed to be created or returned because of exceptions, the related compute node will retry to create instances periodically. This parameter specifies the maximum retry attempts. The max value is 100 and the default value is `7`.
        /// </summary>
        [JsonProperty("ResourceMaxRetryCount")]
        public long? ResourceMaxRetryCount{ get; set; }

        /// <summary>
        /// List of tags to bind with a compute environment. Each compute environment can have up to 10 tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Target of the notification
        /// Values: `CMQ`, `TDMQ_CMQ`
        /// `CMQ`: Tencent Cloud CMQ (default)
        /// `TDMQ_CMQ`: Tencent Cloud TDMQ_CMQ.<br/>Note: CMQ has been discontinued. Please use `TDMQ_CMQ`. See [CMQ Queue Migration to TDMQ for CMQ](https://intl.cloud.tencent.com/document/product/406/60860?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("NotificationTarget")]
        public string NotificationTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "EnvDescription", this.EnvDescription);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
            this.SetParamArrayObj(map, prefix + "MountDataDisks.", this.MountDataDisks);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamObj(map, prefix + "AgentRunningMode.", this.AgentRunningMode);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "ActionIfComputeNodeInactive", this.ActionIfComputeNodeInactive);
            this.SetParamSimple(map, prefix + "ResourceMaxRetryCount", this.ResourceMaxRetryCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NotificationTarget", this.NotificationTarget);
        }
    }
}

