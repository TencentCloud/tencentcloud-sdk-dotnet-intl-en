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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmRiskCount : AbstractModel
    {
        
        /// <summary>
        /// Number of Pending Risks
        /// </summary>
        [JsonProperty("UnprocessedRisk")]
        public long? UnprocessedRisk{ get; set; }

        /// <summary>
        /// Configuration risk count
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        [System.Obsolete]
        public long? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Baseline risk count
        /// </summary>
        [JsonProperty("BaselineDeviation")]
        [System.Obsolete]
        public long? BaselineDeviation{ get; set; }

        /// <summary>
        /// Number of leakage risks
        /// </summary>
        [JsonProperty("LeakDetection")]
        [System.Obsolete]
        public long? LeakDetection{ get; set; }

        /// <summary>
        /// Number of SQL abnormal behavior risks
        /// </summary>
        [JsonProperty("SQLBehaviorAnomaly")]
        public long? SQLBehaviorAnomaly{ get; set; }

        /// <summary>
        /// Number of permission exception risks
        /// </summary>
        [JsonProperty("PermissionAnomaly")]
        public long? PermissionAnomaly{ get; set; }

        /// <summary>
        /// Number of login behavior anomaly risks
        /// </summary>
        [JsonProperty("LoginBehaviorAnomaly")]
        public long? LoginBehaviorAnomaly{ get; set; }

        /// <summary>
        /// Number of attack surface risks
        /// </summary>
        [JsonProperty("AttackSurfaceRisk")]
        public long? AttackSurfaceRisk{ get; set; }

        /// <summary>
        /// Number of sensitive operations on the account
        /// </summary>
        [JsonProperty("AccountSensitiveOperation")]
        public long? AccountSensitiveOperation{ get; set; }

        /// <summary>
        /// Pending alarm count
        /// </summary>
        [JsonProperty("UnprocessedAlarm")]
        public long? UnprocessedAlarm{ get; set; }

        /// <summary>
        /// Newly-added event alarm
        /// </summary>
        [JsonProperty("NumOfNewAlarmEvent")]
        public long? NumOfNewAlarmEvent{ get; set; }

        /// <summary>
        /// Newly-added configuration risk
        /// </summary>
        [JsonProperty("NumOfNewConfigRisk")]
        public long? NumOfNewConfigRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnprocessedRisk", this.UnprocessedRisk);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "BaselineDeviation", this.BaselineDeviation);
            this.SetParamSimple(map, prefix + "LeakDetection", this.LeakDetection);
            this.SetParamSimple(map, prefix + "SQLBehaviorAnomaly", this.SQLBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "PermissionAnomaly", this.PermissionAnomaly);
            this.SetParamSimple(map, prefix + "LoginBehaviorAnomaly", this.LoginBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "AttackSurfaceRisk", this.AttackSurfaceRisk);
            this.SetParamSimple(map, prefix + "AccountSensitiveOperation", this.AccountSensitiveOperation);
            this.SetParamSimple(map, prefix + "UnprocessedAlarm", this.UnprocessedAlarm);
            this.SetParamSimple(map, prefix + "NumOfNewAlarmEvent", this.NumOfNewAlarmEvent);
            this.SetParamSimple(map, prefix + "NumOfNewConfigRisk", this.NumOfNewConfigRisk);
        }
    }
}

