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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// Total free space size in bytes
        /// </summary>
        [JsonProperty("TotalFreeSize")]
        public ulong? TotalFreeSize{ get; set; }

        /// <summary>
        /// Used free space size in bytes
        /// </summary>
        [JsonProperty("UsedFreeSize")]
        public ulong? UsedFreeSize{ get; set; }

        /// <summary>
        /// Used paid space size in bytes
        /// </summary>
        [JsonProperty("UsedBillingSize")]
        public ulong? UsedBillingSize{ get; set; }

        /// <summary>
        /// Number of log backups
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// Log backup size in bytes
        /// </summary>
        [JsonProperty("LogBackupSize")]
        public ulong? LogBackupSize{ get; set; }

        /// <summary>
        /// Number of manually created full backups
        /// </summary>
        [JsonProperty("ManualBaseBackupCount")]
        public ulong? ManualBaseBackupCount{ get; set; }

        /// <summary>
        /// Size of manually created full backups in bytes
        /// </summary>
        [JsonProperty("ManualBaseBackupSize")]
        public ulong? ManualBaseBackupSize{ get; set; }

        /// <summary>
        /// Number of automatically created full backups
        /// </summary>
        [JsonProperty("AutoBaseBackupCount")]
        public ulong? AutoBaseBackupCount{ get; set; }

        /// <summary>
        /// Size of automatically created full backups in bytes
        /// </summary>
        [JsonProperty("AutoBaseBackupSize")]
        public ulong? AutoBaseBackupSize{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalFreeSize", this.TotalFreeSize);
            this.SetParamSimple(map, prefix + "UsedFreeSize", this.UsedFreeSize);
            this.SetParamSimple(map, prefix + "UsedBillingSize", this.UsedBillingSize);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSize", this.LogBackupSize);
            this.SetParamSimple(map, prefix + "ManualBaseBackupCount", this.ManualBaseBackupCount);
            this.SetParamSimple(map, prefix + "ManualBaseBackupSize", this.ManualBaseBackupSize);
            this.SetParamSimple(map, prefix + "AutoBaseBackupCount", this.AutoBaseBackupCount);
            this.SetParamSimple(map, prefix + "AutoBaseBackupSize", this.AutoBaseBackupSize);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

