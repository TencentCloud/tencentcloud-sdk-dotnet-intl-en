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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossSummaryDetailRes : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CrossBackupEnabled")]
        public string CrossBackupEnabled{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LastBackupStartTime")]
        public string LastBackupStartTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CrossBackupSaveDays")]
        public long? CrossBackupSaveDays{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public ulong? DataBackupSpace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public ulong? DataBackupCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public ulong? LogBackupSpace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ActualUsedCount")]
        public ulong? ActualUsedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CrossBackupEnabled", this.CrossBackupEnabled);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "LastBackupStartTime", this.LastBackupStartTime);
            this.SetParamSimple(map, prefix + "CrossBackupSaveDays", this.CrossBackupSaveDays);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "ActualUsedCount", this.ActualUsedCount);
        }
    }
}

