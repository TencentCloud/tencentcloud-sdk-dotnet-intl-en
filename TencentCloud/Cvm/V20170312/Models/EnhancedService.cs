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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnhancedService : AbstractModel
    {
        
        /// <summary>
        /// Enables cloud security service. If this parameter is not specified, the cloud security service will be enabled by default.
        /// </summary>
        [JsonProperty("SecurityService")]
        public RunSecurityServiceEnabled SecurityService{ get; set; }

        /// <summary>
        /// Enables cloud monitor service. If this parameter is not specified, the cloud monitor service will be enabled by default.
        /// </summary>
        [JsonProperty("MonitorService")]
        public RunMonitorServiceEnabled MonitorService{ get; set; }

        /// <summary>
        /// Whether to enable the TAT service. If this parameter is not specified, the TAT service is enabled for public images and disabled for other images by default.
        /// </summary>
        [JsonProperty("AutomationService")]
        public RunAutomationServiceEnabled AutomationService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityService.", this.SecurityService);
            this.SetParamObj(map, prefix + "MonitorService.", this.MonitorService);
            this.SetParamObj(map, prefix + "AutomationService.", this.AutomationService);
        }
    }
}

