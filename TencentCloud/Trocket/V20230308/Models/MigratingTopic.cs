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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigratingTopic : AbstractModel
    {
        
        /// <summary>
        /// Topic name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Migration status. 
        /// S_RW_D_NA source cluster read/write.
        /// S_RW_D_R specifies read and write permissions for the source cluster and read permissions for the target cluster.
        /// S_RW_D_RW specifies read-write for the source cluster and read-write for the target cluster.
        /// SRDRW specifies source cluster read and destination cluster read/write.
        /// S_NA_D_RW specifies the read-write target cluster.
        /// </summary>
        [JsonProperty("MigrationStatus")]
        public string MigrationStatus{ get; set; }

        /// <summary>
        /// Specifies whether the health check is completed.	
        /// </summary>
        [JsonProperty("HealthCheckPassed")]
        public bool? HealthCheckPassed{ get; set; }

        /// <summary>
        /// Error information returned by the last health check is valid only when HealthCheckPassed is false. NotChecked: check not executed. Unknown: Unknown error. TopicNotImported: topic not imported. TopicNotExistsInSourceCluster: topic does not exist in the source cluster. TopicNotExistsInTargetCluster: topic does not exist in the target cluster. ConsumerConnectedOnTarget: consumer connections exist on the target cluster. SourceTopicHasNewMessagesIn5Minutes: new messages were written to the source cluster topic in the last 5 Minutes. TargetTopicHasNewMessagesIn5Minutes: new messages were written to the target cluster topic in the last 5 Minutes. SourceTopicHasNoMessagesIn5Minutes: no new messages were written to the source cluster in the last 5 Minutes. TargetTopicHasNoMessagesIn5Minutes: no new messages were written to the target cluster in the last 5 Minutes. ConsumerGroupCountNotMatch: inconsistent number of subscription groups. SourceTopicHasUnconsumedMessages: unconsumed messages exist in the source cluster topic.
        /// </summary>
        [JsonProperty("HealthCheckError")]
        public string HealthCheckError{ get; set; }

        /// <summary>
        /// Namespace. specifies that it is only valid for 4.x clusters.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Namespace of 4.x.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NamespaceV4")]
        public string NamespaceV4{ get; set; }

        /// <summary>
        /// Topic name for version 4.x.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicNameV4")]
        public string TopicNameV4{ get; set; }

        /// <summary>
        /// Complete namespace for 4.x.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FullNamespaceV4")]
        public string FullNamespaceV4{ get; set; }

        /// <summary>
        /// Error list returned from the last health check.
        /// </summary>
        [JsonProperty("HealthCheckErrorList")]
        public string[] HealthCheckErrorList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MigrationStatus", this.MigrationStatus);
            this.SetParamSimple(map, prefix + "HealthCheckPassed", this.HealthCheckPassed);
            this.SetParamSimple(map, prefix + "HealthCheckError", this.HealthCheckError);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "NamespaceV4", this.NamespaceV4);
            this.SetParamSimple(map, prefix + "TopicNameV4", this.TopicNameV4);
            this.SetParamSimple(map, prefix + "FullNamespaceV4", this.FullNamespaceV4);
            this.SetParamArraySimple(map, prefix + "HealthCheckErrorList.", this.HealthCheckErrorList);
        }
    }
}

