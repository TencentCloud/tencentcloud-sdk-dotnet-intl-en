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

    public class AbnormalProcessEventInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Process directory.</p>
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// <p>Event type. MALICE_PROCESS_START: malicious process startup.</p>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// <p>Hit rule name. PROXY_TOOL: proxy software; TRANSFER_CONTROL: lateral movement; ATTACK_CMD: malicious command; REVERSE_SHELL: reverse shell; FILELESS: fileless execution; RISK_CMD: high-risk command; ABNORMAL_CHILD_PROC: abnormal child process startup of sensitive service; USER_DEFINED_RULE: user-defined rule</p>
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// <p>Generation time.</p>
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// <p>Container name.</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>Image name.</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>Action execution result: BEHAVIOR_NONE: none<br>BEHAVIOR_ALERT: alarm<br>BEHAVIOR_RELEASE: allow<br>BEHAVIOR_HOLDUP_FAILED: block failed<br>BEHAVIOR_HOLDUP_SUCCESSED: block succeeded</p>
        /// </summary>
        [JsonProperty("Behavior")]
        public string Behavior{ get; set; }

        /// <summary>
        /// <p>Status: EVENT_UNDEAL: event unhandled<br>    EVENT_DEALED: event handled<br>    EVENT_INGNORE: event ignored</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Unique ID of the event record.</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Image ID, used for redirection.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Container ID, used for redirection.</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>Event solution.</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>Event detailed description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Hit policy ID.</p>
        /// </summary>
        [JsonProperty("MatchRuleId")]
        public string MatchRuleId{ get; set; }

        /// <summary>
        /// <p>Hit rule action:<br>RULE_MODE_RELEASE: allow<br>RULE_MODE_ALERT: alarm<br>RULE_MODE_HOLDUP: block</p>
        /// </summary>
        [JsonProperty("MatchAction")]
        public string MatchAction{ get; set; }

        /// <summary>
        /// <p>Hit rule process information.</p>
        /// </summary>
        [JsonProperty("MatchProcessPath")]
        public string MatchProcessPath{ get; set; }

        /// <summary>
        /// <p>Whether the rule exists.</p>
        /// </summary>
        [JsonProperty("RuleExist")]
        public bool? RuleExist{ get; set; }

        /// <summary>
        /// <p>Number of events.</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>Last generation time.</p>
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// <p>Rule group ID.</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Hit policy name: SYSTEM_DEFINED_RULE (system policy) or user-defined policy name.</p>
        /// </summary>
        [JsonProperty("MatchGroupName")]
        public string MatchGroupName{ get; set; }

        /// <summary>
        /// <p>Hit rule level: HIGH, MIDDLE, and LOW.</p>
        /// </summary>
        [JsonProperty("MatchRuleLevel")]
        public string MatchRuleLevel{ get; set; }

        /// <summary>
        /// <p>Network status<br>Not isolated: NORMAL<br>Isolated: ISOLATED<br>Isolating: ISOLATING<br>Isolation failed: ISOLATE_FAILED<br>Restoring: RESTORING<br>Restoring failed: RESTORE_FAILED</p>
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// <p>Container sub-status.<br>&quot;AGENT_OFFLINE&quot;       //Agent offline<br>&quot;NODE_DESTROYED&quot;      //Node destroyed<br>&quot;CONTAINER_EXITED&quot;    //Container exited<br>&quot;CONTAINER_DESTROYED&quot; //Container destroyed<br>&quot;SHARED_HOST&quot;         //Container and host sharing the network<br>&quot;RESOURCE_LIMIT&quot;      //Resource limit exceeded for the isolation operation<br>&quot;UNKNOW&quot;              //Unknown reason</p>
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// <p>Source of container isolation operation.</p>
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// <p>Container status.<br>RUNNING<br>PAUSED<br>STOPPED<br>CREATED<br>DESTROYED<br>RESTARTING<br>REMOVING</p>
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>Node type: NORMAL (normal node) and SUPER (super node).</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Pod name.</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>pod ip</p>
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// <p>Node public IP address.</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>Node name.</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>Node ID.</p>
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// <p>uuid</p>
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// <p>Node private IP address.</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Command line parameters.</p>
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }


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
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
        }
    }
}

