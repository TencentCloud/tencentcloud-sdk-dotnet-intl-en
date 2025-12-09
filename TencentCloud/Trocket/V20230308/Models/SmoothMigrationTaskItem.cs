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

    public class SmoothMigrationTaskItem : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task name.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Source cluster name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceClusterName")]
        public string SourceClusterName{ get; set; }

        /// <summary>
        /// Destination cluster instance ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the network connection type. 
        /// PUBLIC network. 
        /// Specifies the VPC virtual private cloud. 
        /// OTHER.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConnectionType")]
        public string ConnectionType{ get; set; }

        /// <summary>
        /// Source cluster NameServer address.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceNameServer")]
        public string SourceNameServer{ get; set; }

        /// <summary>
        /// Task status.
        /// Migration Configuration. specifies the migration Configuration.
        /// SourceConnecting specifies connecting to source cluster.
        /// MetaDataImport specifies metadata import.
        /// EndpointSetup specifies the access point switchover.
        /// Service migration is in progress.
        /// Completed.
        /// Cancelled: canceled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// Specifies the target cluster instance version.
        /// 4 indicates version 4.x.
        /// 5 indicates version 5.x.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "SourceClusterName", this.SourceClusterName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConnectionType", this.ConnectionType);
            this.SetParamSimple(map, prefix + "SourceNameServer", this.SourceNameServer);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
        }
    }
}

