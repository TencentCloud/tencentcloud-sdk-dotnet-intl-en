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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PerformanceMonitorSet : AbstractModel
    {
        
        /// <summary>
        /// Number of UPDATE operations
        /// </summary>
        [JsonProperty("UpdateTotal")]
        public MonitorData UpdateTotal{ get; set; }

        /// <summary>
        /// Number of disk IOs per second
        /// </summary>
        [JsonProperty("DiskIops")]
        public MonitorData DiskIops{ get; set; }

        /// <summary>
        /// Number of active connections
        /// </summary>
        [JsonProperty("ConnActive")]
        public MonitorData ConnActive{ get; set; }

        /// <summary>
        /// Cache hit rate
        /// </summary>
        [JsonProperty("MemHitRate")]
        public MonitorData MemHitRate{ get; set; }

        /// <summary>
        /// Master/slave delay
        /// </summary>
        [JsonProperty("SlaveDelay")]
        public MonitorData SlaveDelay{ get; set; }

        /// <summary>
        /// Number of SELECT operations
        /// </summary>
        [JsonProperty("SelectTotal")]
        public MonitorData SelectTotal{ get; set; }

        /// <summary>
        /// Number of slow queries
        /// </summary>
        [JsonProperty("LongQuery")]
        public MonitorData LongQuery{ get; set; }

        /// <summary>
        /// Number of DELETE operations
        /// </summary>
        [JsonProperty("DeleteTotal")]
        public MonitorData DeleteTotal{ get; set; }

        /// <summary>
        /// Number of INSERT operations
        /// </summary>
        [JsonProperty("InsertTotal")]
        public MonitorData InsertTotal{ get; set; }

        /// <summary>
        /// Whether master/slave switch occurred. 1: yes, 0: no
        /// </summary>
        [JsonProperty("IsMasterSwitched")]
        public MonitorData IsMasterSwitched{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UpdateTotal.", this.UpdateTotal);
            this.SetParamObj(map, prefix + "DiskIops.", this.DiskIops);
            this.SetParamObj(map, prefix + "ConnActive.", this.ConnActive);
            this.SetParamObj(map, prefix + "MemHitRate.", this.MemHitRate);
            this.SetParamObj(map, prefix + "SlaveDelay.", this.SlaveDelay);
            this.SetParamObj(map, prefix + "SelectTotal.", this.SelectTotal);
            this.SetParamObj(map, prefix + "LongQuery.", this.LongQuery);
            this.SetParamObj(map, prefix + "DeleteTotal.", this.DeleteTotal);
            this.SetParamObj(map, prefix + "InsertTotal.", this.InsertTotal);
            this.SetParamObj(map, prefix + "IsMasterSwitched.", this.IsMasterSwitched);
        }
    }
}

