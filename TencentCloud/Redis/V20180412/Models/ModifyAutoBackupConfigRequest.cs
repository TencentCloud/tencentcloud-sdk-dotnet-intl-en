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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Date. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// Time period. Value range: 00:00-01:00, 01:00-02:00...... 23:00-00:00
        /// </summary>
        [JsonProperty("TimePeriod")]
        public string TimePeriod{ get; set; }

        /// <summary>
        /// Auto backup type: 1 "scheduled rollback"
        /// </summary>
        [JsonProperty("AutoBackupType")]
        public long? AutoBackupType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "TimePeriod", this.TimePeriod);
            this.SetParamSimple(map, prefix + "AutoBackupType", this.AutoBackupType);
        }
    }
}

