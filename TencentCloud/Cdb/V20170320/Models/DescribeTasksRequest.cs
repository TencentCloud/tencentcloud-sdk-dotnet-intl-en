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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page. You can use the [instance list querying API](https://cloud.tencent.com/document/api/236/15872) to query the ID, whose value is the `InstanceId` value in output parameters.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ID of an async task request, i.e., `AsyncRequestId` returned by relevant TencentDB operations.
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public string AsyncRequestId{ get; set; }

        /// <summary>
        /// Task type. If no value is passed in, all task types will be queried. Valid values:
        /// 1 - rolling back a database;
        /// 2 - performing an SQL operation;
        /// 3 - importing data;
        /// 5 - setting a parameter;
        /// 6 - initializing a TencentDB instance;
        /// 7 - restarting a TencentDB instance;
        /// 8 - enabling GTID of a TencentDB instance;
        /// 9 - upgrading a read-only instance;
        /// 10 - rolling back databases in batches;
        /// 11 - upgrading a primary instance;
        /// 12 - deleting a TencentDB table;
        /// 13 - promoting a disaster recovery instance.
        /// </summary>
        [JsonProperty("TaskTypes")]
        public long?[] TaskTypes{ get; set; }

        /// <summary>
        /// Task status. If no value is passed in, all task statuses will be queried. Valid values:
        /// -1 - undefined;
        /// 0 - initializing;
        /// 1 - running;
        /// 2 - succeeded;
        /// 3 - failed;
        /// 4 - terminated;
        /// 5 - deleted;
        /// 6 - paused.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// Start time of the first task in the format of yyyy-MM-dd HH:mm:ss, such as 2017-12-31 10:40:01. It is used for queries by time range.
        /// </summary>
        [JsonProperty("StartTimeBegin")]
        public string StartTimeBegin{ get; set; }

        /// <summary>
        /// End time of the last task in the format of yyyy-MM-dd HH:mm:ss, such as 2017-12-31 10:40:01. It is used for queries by time range.
        /// </summary>
        [JsonProperty("StartTimeEnd")]
        public string StartTimeEnd{ get; set; }

        /// <summary>
        /// Record offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned for a single request. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamSimple(map, prefix + "StartTimeBegin", this.StartTimeBegin);
            this.SetParamSimple(map, prefix + "StartTimeEnd", this.StartTimeEnd);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

