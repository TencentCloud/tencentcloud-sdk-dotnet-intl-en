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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnhancedService : AbstractModel
    {
        
        /// <summary>
        /// Enables the Cloud Security service. If this parameter is not specified, the Cloud Security service will be enabled by default.
        /// </summary>
        [JsonProperty("SecurityService")]
        public RunSecurityServiceEnabled SecurityService{ get; set; }

        /// <summary>
        /// Enables the Cloud Monitor service. If this parameter is not specified, the Cloud Monitor service will be enabled by default.
        /// </summary>
        [JsonProperty("MonitorService")]
        public RunMonitorServiceEnabled MonitorService{ get; set; }

        /// <summary>
        /// Deprecated parameter.
        /// </summary>
        [JsonProperty("AutomationService")]
        [System.Obsolete]
        public RunAutomationServiceEnabled[] AutomationService{ get; set; }

        /// <summary>
        /// Enable TAT service. If this parameter is not specified, the default logic is the same as that of the CVM instance. Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutomationToolsService")]
        public RunAutomationServiceEnabled AutomationToolsService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityService.", this.SecurityService);
            this.SetParamObj(map, prefix + "MonitorService.", this.MonitorService);
            this.SetParamArrayObj(map, prefix + "AutomationService.", this.AutomationService);
            this.SetParamObj(map, prefix + "AutomationToolsService.", this.AutomationToolsService);
        }
    }
}

