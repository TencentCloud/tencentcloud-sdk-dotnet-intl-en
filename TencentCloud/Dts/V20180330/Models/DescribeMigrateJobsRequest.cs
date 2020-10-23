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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMigrateJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// Data migration task ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Data migration task name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Sort by field. Value range: JobId, Status, JobName, MigrateType, RunMode, CreateTime
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting order. Value range: ASC (ascending), DESC (descending)
        /// </summary>
        [JsonProperty("OrderSeq")]
        public string OrderSeq{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of the returned instances. Value range: [1, 100]. Default value: 20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderSeq", this.OrderSeq);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

