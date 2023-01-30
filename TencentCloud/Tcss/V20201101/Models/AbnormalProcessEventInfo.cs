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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessEventInfo : AbstractModel
    {
        
        /// <summary>
        /// Process directory
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// Event type. `MALICE_PROCESS_START`: Malicious process startup.
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Name of the hit rule. Valid values: `PROXY_TOOL` (proxy); `TRANSFER_CONTROL` (lateral movement); `ATTACK_CMD` (malicious command); `REVERSE_SHELL` (reverse shell); `FILELESS` (fileless execution); `RISK_CMD` (high-risk command); `ABNORMAL_CHILD_PROC` (unusual start found in the child process of the sensitive service); `USER_DEFINED_RULE` (custom rule).
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// Generation time
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Action execution result. `BEHAVIOR_NONE`: None.
        ///     `BEHAVIOR_ALERT`: Alert.
        ///     `BEHAVIOR_RELEASE`: Allow.
        ///     `BEHAVIOR_HOLDUP_FAILED`: Failed to block.
        ///     `BEHAVIOR_HOLDUP_SUCCESSED`: Blocked.
        /// </summary>
        [JsonProperty("Behavior")]
        public string Behavior{ get; set; }

        /// <summary>
        /// Status. `EVENT_UNDEAL`: Pending.
        ///     `EVENT_DEALED`: Processed.
        ///     `EVENT_INGNORE`: Ignored.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Unique event ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Image ID, which is used for redirect.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Container ID, which is used for redirect.
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// Event solution
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Hit policy ID
        /// </summary>
        [JsonProperty("MatchRuleId")]
        public string MatchRuleId{ get; set; }

        /// <summary>
        /// Action of the hit rule:
        /// `RULE_MODE_RELEASE`: Allow.
        /// `RULE_MODE_ALERT`: Alert.
        /// `RULE_MODE_HOLDUP`: Block.
        /// </summary>
        [JsonProperty("MatchAction")]
        public string MatchAction{ get; set; }

        /// <summary>
        /// Information of the process that hits the rule
        /// </summary>
        [JsonProperty("MatchProcessPath")]
        public string MatchProcessPath{ get; set; }

        /// <summary>
        /// Whether the rule exists
        /// </summary>
        [JsonProperty("RuleExist")]
        public bool? RuleExist{ get; set; }

        /// <summary>
        /// Number of events
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// Last generation time
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// Rule group ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Name of the hit policy. Valid values: `SYSTEM_DEFINED_RULE` (preset policy); name of the custom policy.
        /// </summary>
        [JsonProperty("MatchGroupName")]
        public string MatchGroupName{ get; set; }

        /// <summary>
        /// Level of the hit rule. Valid values: `HIGH` (high); `MIDDLE` (medium); `LOW` (low).
        /// </summary>
        [JsonProperty("MatchRuleLevel")]
        public string MatchRuleLevel{ get; set; }

        /// <summary>
        /// Network status
        /// `NORMAL`: 	Not isolated.
        /// `ISOLATED`: 		Isolated.
        /// `ISOLATING`: 		Isolating.
        /// `ISOLATE_FAILED`: 	Isolation failed.
        /// `RESTORING`: Recovering.
        /// `RESTORE_FAILED`: Recovery failed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// Sub-status of the container
        /// "AGENT_OFFLINE"       // The agent is offline.
        /// "NODE_DESTROYED"      // The node is terminated.
        /// "CONTAINER_EXITED"    // The container exited.
        /// "CONTAINER_DESTROYED" // The container was terminated.
        /// "SHARED_HOST"         // The container shares the network with the server.
        /// "RESOURCE_LIMIT"      // The number of resources to be isolated exceeds the limit.
        /// "UNKNOW"              // The reason is unknown.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// Container isolation operation source
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// Container status
        /// `RUNNING`: Running.
        /// `PAUSED`: Paused.
        /// `STOPPED`: Stopped.
        /// `CREATED`: Created.
        /// `DESTROYED`: Terminated.
        /// `RESTARTING`: Restarting.
        /// `REMOVING`: Removing.
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "MatchRuleName", this.MatchRuleName);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Behavior", this.Behavior);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MatchRuleId", this.MatchRuleId);
            this.SetParamSimple(map, prefix + "MatchAction", this.MatchAction);
            this.SetParamSimple(map, prefix + "MatchProcessPath", this.MatchProcessPath);
            this.SetParamSimple(map, prefix + "RuleExist", this.RuleExist);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "MatchGroupName", this.MatchGroupName);
            this.SetParamSimple(map, prefix + "MatchRuleLevel", this.MatchRuleLevel);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
        }
    }
}

