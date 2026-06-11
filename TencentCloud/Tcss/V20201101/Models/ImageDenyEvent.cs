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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageDenyEvent : AbstractModel
    {
        
        /// <summary>
        /// Event Type. EVENT_RISK: Risk Event Type; EVENT_PRIVILEGE: Privilege
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// Rule type
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Rule Enable Status. 0: Enabled; 1: Disabled
        /// </summary>
        [JsonProperty("RuleStatus")]
        public long? RuleStatus{ get; set; }

        /// <summary>
        /// Rule Policy Status. IN_THE_TEST: Observing; IN_EFFECT: Effective
        /// </summary>
        [JsonProperty("RuleEffectStatus")]
        public string RuleEffectStatus{ get; set; }

        /// <summary>
        /// Rule content
        /// </summary>
        [JsonProperty("RuleInfo")]
        public string[] RuleInfo{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("RuleDescription")]
        public string RuleDescription{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// Image Name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("NodeIP")]
        public string NodeIP{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// First generation time
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// Latest creation time
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// Number of events
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// Execution action
        /// BEHAVIOR_ALERT: Alert
        /// BEHAVIOR_HOLDUP_SUCCESSED: Interception
        /// </summary>
        [JsonProperty("DealBehavior")]
        public string DealBehavior{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("EventID")]
        public long? EventID{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// Node type.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Super Node Unique ID
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// pod ip
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Image repository information.
        /// </summary>
        [JsonProperty("ImageRegistryInfo")]
        public ImageRegistryInfo ImageRegistryInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamSimple(map, prefix + "RuleEffectStatus", this.RuleEffectStatus);
            this.SetParamArraySimple(map, prefix + "RuleInfo.", this.RuleInfo);
            this.SetParamSimple(map, prefix + "RuleDescription", this.RuleDescription);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeIP", this.NodeIP);
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "DealBehavior", this.DealBehavior);
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamObj(map, prefix + "ImageRegistryInfo.", this.ImageRegistryInfo);
        }
    }
}

