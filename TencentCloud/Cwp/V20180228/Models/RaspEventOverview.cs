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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RaspEventOverview : AbstractModel
    {
        
        /// <summary>
        /// Number of protectable vulnerabilities
        /// </summary>
        [JsonProperty("DefenceVuls")]
        public long? DefenceVuls{ get; set; }

        /// <summary>
        /// Number of accurately prevented vulnerabilities
        /// </summary>
        [JsonProperty("PreciseDefenseVuls")]
        public long? PreciseDefenseVuls{ get; set; }

        /// <summary>
        /// Unprocessed application defense event count
        /// </summary>
        [JsonProperty("UnhandledRaspEvents")]
        public long? UnhandledRaspEvents{ get; set; }

        /// <summary>
        /// Number of unprocessed Java Webshell scan events
        /// </summary>
        [JsonProperty("UnhandledMemShellScanEvents")]
        public long? UnhandledMemShellScanEvents{ get; set; }

        /// <summary>
        /// Number of unprocessed memory shell injection events
        /// </summary>
        [JsonProperty("UnhandledMemShellInjectEvents")]
        public long? UnhandledMemShellInjectEvents{ get; set; }

        /// <summary>
        /// Daily event handling trend
        /// </summary>
        [JsonProperty("UnHandledEvents")]
        public long?[] UnHandledEvents{ get; set; }

        /// <summary>
        /// Daily vulnerability detect event trend
        /// </summary>
        [JsonProperty("RaspAttackCounts")]
        public long?[] RaspAttackCounts{ get; set; }

        /// <summary>
        /// Daily vulnerability defense event trend
        /// </summary>
        [JsonProperty("RaspDefendCounts")]
        public long?[] RaspDefendCounts{ get; set; }

        /// <summary>
        /// Daily Java Webshell detect event trend
        /// </summary>
        [JsonProperty("MemShellAttackCounts")]
        public long?[] MemShellAttackCounts{ get; set; }

        /// <summary>
        /// Daily Java Webshell defense event trends
        /// </summary>
        [JsonProperty("MemShellDefendCounts")]
        public long?[] MemShellDefendCounts{ get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("Date")]
        public string[] Date{ get; set; }

        /// <summary>
        /// Enable RASP protection switch number of assets
        /// </summary>
        [JsonProperty("ProtectAssetOpenCount")]
        public ulong? ProtectAssetOpenCount{ get; set; }

        /// <summary>
        /// Total number of assets
        /// </summary>
        [JsonProperty("ProtectAssetCount")]
        public ulong? ProtectAssetCount{ get; set; }

        /// <summary>
        /// Number of asset protection bound to the flagship edition
        /// </summary>
        [JsonProperty("UltimateAssetCount")]
        public ulong? UltimateAssetCount{ get; set; }

        /// <summary>
        /// Number of assets bound to the Prioritized Protection package
        /// </summary>
        [JsonProperty("RaspAssetCount")]
        public ulong? RaspAssetCount{ get; set; }

        /// <summary>
        /// Number of unauthorized assets
        /// </summary>
        [JsonProperty("NotProtectAssetCount")]
        public ulong? NotProtectAssetCount{ get; set; }

        /// <summary>
        /// Pending events count in the last 7 days
        /// </summary>
        [JsonProperty("RecentUnhandledEvents")]
        public long? RecentUnhandledEvents{ get; set; }

        /// <summary>
        /// Total Number of Successful Defenses
        /// </summary>
        [JsonProperty("RaspDefendCount")]
        public long? RaspDefendCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefenceVuls", this.DefenceVuls);
            this.SetParamSimple(map, prefix + "PreciseDefenseVuls", this.PreciseDefenseVuls);
            this.SetParamSimple(map, prefix + "UnhandledRaspEvents", this.UnhandledRaspEvents);
            this.SetParamSimple(map, prefix + "UnhandledMemShellScanEvents", this.UnhandledMemShellScanEvents);
            this.SetParamSimple(map, prefix + "UnhandledMemShellInjectEvents", this.UnhandledMemShellInjectEvents);
            this.SetParamArraySimple(map, prefix + "UnHandledEvents.", this.UnHandledEvents);
            this.SetParamArraySimple(map, prefix + "RaspAttackCounts.", this.RaspAttackCounts);
            this.SetParamArraySimple(map, prefix + "RaspDefendCounts.", this.RaspDefendCounts);
            this.SetParamArraySimple(map, prefix + "MemShellAttackCounts.", this.MemShellAttackCounts);
            this.SetParamArraySimple(map, prefix + "MemShellDefendCounts.", this.MemShellDefendCounts);
            this.SetParamArraySimple(map, prefix + "Date.", this.Date);
            this.SetParamSimple(map, prefix + "ProtectAssetOpenCount", this.ProtectAssetOpenCount);
            this.SetParamSimple(map, prefix + "ProtectAssetCount", this.ProtectAssetCount);
            this.SetParamSimple(map, prefix + "UltimateAssetCount", this.UltimateAssetCount);
            this.SetParamSimple(map, prefix + "RaspAssetCount", this.RaspAssetCount);
            this.SetParamSimple(map, prefix + "NotProtectAssetCount", this.NotProtectAssetCount);
            this.SetParamSimple(map, prefix + "RecentUnhandledEvents", this.RecentUnhandledEvents);
            this.SetParamSimple(map, prefix + "RaspDefendCount", this.RaspDefendCount);
        }
    }
}

