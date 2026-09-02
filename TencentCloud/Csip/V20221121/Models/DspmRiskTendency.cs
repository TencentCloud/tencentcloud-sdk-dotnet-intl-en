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

    public class DspmRiskTendency : AbstractModel
    {
        
        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Number of unmanaged accounts
        /// </summary>
        [JsonProperty("UncontrolledAccount")]
        public long? UncontrolledAccount{ get; set; }

        /// <summary>
        /// Number of configuration risks
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        [System.Obsolete]
        public long? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Baseline risk count
        /// </summary>
        [JsonProperty("BaselineRisk")]
        [System.Obsolete]
        public long? BaselineRisk{ get; set; }

        /// <summary>
        /// Number of leakage risks
        /// </summary>
        [JsonProperty("LeakDetectionRisk")]
        [System.Obsolete]
        public long? LeakDetectionRisk{ get; set; }

        /// <summary>
        /// Number of SQL behavior anomaly risks
        /// </summary>
        [JsonProperty("SQLBehaviorAnomaly")]
        public long? SQLBehaviorAnomaly{ get; set; }

        /// <summary>
        /// Number of permission abnormal risks
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
        /// Number of sensitive operations for the account
        /// </summary>
        [JsonProperty("AccountSensitiveOperation")]
        public long? AccountSensitiveOperation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "UncontrolledAccount", this.UncontrolledAccount);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "BaselineRisk", this.BaselineRisk);
            this.SetParamSimple(map, prefix + "LeakDetectionRisk", this.LeakDetectionRisk);
            this.SetParamSimple(map, prefix + "SQLBehaviorAnomaly", this.SQLBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "PermissionAnomaly", this.PermissionAnomaly);
            this.SetParamSimple(map, prefix + "LoginBehaviorAnomaly", this.LoginBehaviorAnomaly);
            this.SetParamSimple(map, prefix + "AttackSurfaceRisk", this.AttackSurfaceRisk);
            this.SetParamSimple(map, prefix + "AccountSensitiveOperation", this.AccountSensitiveOperation);
        }
    }
}

