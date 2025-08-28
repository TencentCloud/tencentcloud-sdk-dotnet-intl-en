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

    public class SummaryDetailRes : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

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
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

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
        [JsonProperty("AutoBackupSpace")]
        public ulong? AutoBackupSpace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public ulong? AutoBackupCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ManualBackupSpace")]
        public ulong? ManualBackupSpace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public ulong? ManualBackupCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSpace", this.AutoBackupSpace);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSpace", this.ManualBackupSpace);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

