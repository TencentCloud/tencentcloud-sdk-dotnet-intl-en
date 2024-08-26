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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackUpScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// Required to be uploaded when editing
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// Selected weeks, separated by commas.
        /// Discarded: Use ScheduleInfo.
        /// </summary>
        [JsonProperty("WeekDays")]
        public string WeekDays{ get; set; }

        /// <summary>
        /// Hour for executing the backup taskDiscarded: Use ScheduleInfo.
        /// </summary>
        [JsonProperty("ExecuteHour")]
        public long? ExecuteHour{ get; set; }

        /// <summary>
        /// Backup table list
        /// </summary>
        [JsonProperty("BackUpTables")]
        public BackupTableContent[] BackUpTables{ get; set; }

        /// <summary>
        /// 0: default; 1: one-time backup for the remote Doris
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// Connection information of the remote doris cluster
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public DorisSourceInfo DorisSourceInfo{ get; set; }

        /// <summary>
        /// 0: default; 1: one-time backup; 2: remote backup
        /// </summary>
        [JsonProperty("BackupTimeType")]
        public long? BackupTimeType{ get; set; }

        /// <summary>
        /// 0: default; 1: immediate recovery after the backup is completed.
        /// </summary>
        [JsonProperty("RestoreType")]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// 0: default; 1: connecting to COS using a custom key.
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// Cos certification information
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public CosSourceInfo CosSourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "WeekDays", this.WeekDays);
            this.SetParamSimple(map, prefix + "ExecuteHour", this.ExecuteHour);
            this.SetParamArrayObj(map, prefix + "BackUpTables.", this.BackUpTables);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamObj(map, prefix + "DorisSourceInfo.", this.DorisSourceInfo);
            this.SetParamSimple(map, prefix + "BackupTimeType", this.BackupTimeType);
            this.SetParamSimple(map, prefix + "RestoreType", this.RestoreType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamObj(map, prefix + "CosSourceInfo.", this.CosSourceInfo);
        }
    }
}

