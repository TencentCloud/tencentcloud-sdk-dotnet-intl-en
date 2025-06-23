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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployRecord : AbstractModel
    {
        
        /// <summary>
        /// Total number.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Total successes
        /// </summary>
        [JsonProperty("SuccessTotalCount")]
        public long? SuccessTotalCount{ get; set; }

        /// <summary>
        /// Total failed deployments.
        /// </summary>
        [JsonProperty("FailedTotalCount")]
        public long? FailedTotalCount{ get; set; }

        /// <summary>
        /// Deployment in progress total number.
        /// </summary>
        [JsonProperty("RunningTotalCount")]
        public long? RunningTotalCount{ get; set; }

        /// <summary>
        /// Deployment record type 0 specifies deployment, 1 indicates rollback.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Deployment record detail list.
        /// </summary>
        [JsonProperty("RecordDetailList")]
        public DeployRecordList[] RecordDetailList{ get; set; }

        /// <summary>
        /// Hosted resource deployment state: `0` (awaiting deployment), `1` (deployment successful), `2` (deployment failed), `3` (deploying), `4` (rollback successful), `5` (rollback failure).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Managed resource creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "SuccessTotalCount", this.SuccessTotalCount);
            this.SetParamSimple(map, prefix + "FailedTotalCount", this.FailedTotalCount);
            this.SetParamSimple(map, prefix + "RunningTotalCount", this.RunningTotalCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "RecordDetailList.", this.RecordDetailList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

