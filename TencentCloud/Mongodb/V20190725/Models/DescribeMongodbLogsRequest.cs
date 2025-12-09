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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMongodbLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb#/), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Start time for querying logs.
        /// - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-01 10:00:00.
        /// - Query time range: Only log data within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time for querying logs.
        /// - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-01 10:00:00.
        /// - Query time range: Only log data within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Node ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and go to the **Node Management** page to obtain the ID of the node to be queried.
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// Log category.
        /// - Log categories include but are not limited to COMMAND, ACCESS, CONTROL, FTDC, INDEX, NETWORK, QUERY, REPL, SHARDING, STORAGE, RECOVERY, JOURNAL, and WRITE. The specific supported categories may vary depending on the MongoDB version. For details, see Log Messages (https://www.mongodb.com/zh-cn/docs/v5.0/reference/log-messages/#log-message-examples).
        /// - Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and view the **log category** on the **Error Log** tab of the **Log Management** page.
        /// </summary>
        [JsonProperty("LogComponents")]
        public string[] LogComponents{ get; set; }

        /// <summary>
        /// Log level.
        /// - The log levels are ranked by severity from high to low: FATAL, ERROR, and WARNING.
        /// -Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and view the **log level** on the **Error Log** tab of the **Log Management** page.
        /// </summary>
        [JsonProperty("LogLevels")]
        public string[] LogLevels{ get; set; }

        /// <summary>
        /// Log ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and view the **log ID** on the **Error Log** tab of the **Log Management** page.
        /// </summary>
        [JsonProperty("LogIds")]
        public string[] LogIds{ get; set; }

        /// <summary>
        /// Log connection information. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and view the **log connection information** on the **Error Log** tab of the **Log Management** page.
        /// </summary>
        [JsonProperty("LogConnections")]
        public string[] LogConnections{ get; set; }

        /// <summary>
        /// Specifies the field for filtering the logs.
        /// </summary>
        [JsonProperty("LogDetailParams")]
        public string[] LogDetailParams{ get; set; }

        /// <summary>
        /// Offset. The minimum value is 0, and the maximum value is 10000. The default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination size. The minimum value is 1, and the maximum value is 100. The default value is 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamArraySimple(map, prefix + "LogComponents.", this.LogComponents);
            this.SetParamArraySimple(map, prefix + "LogLevels.", this.LogLevels);
            this.SetParamArraySimple(map, prefix + "LogIds.", this.LogIds);
            this.SetParamArraySimple(map, prefix + "LogConnections.", this.LogConnections);
            this.SetParamArraySimple(map, prefix + "LogDetailParams.", this.LogDetailParams);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

