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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// Health check type. Valid values: `HttpGet`, `TcpSocket`, `Exec`
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The protocol type. It’s only valid when the health check type is `HttpGet`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The request path. It’s only valid when the health check type is `HttpGet`.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// The script to be executed. It’s only valid when the health check type is `Exec`.
        /// </summary>
        [JsonProperty("Exec")]
        public string Exec{ get; set; }

        /// <summary>
        /// The request port. It’s only valid when the health check type is `HttpGet` or `TcpSocket `.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// The initial delay for health check in seconds. Default: `0`
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// Timeout period in seconds. Default: `1`
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// Interval period in seconds. Default: `10`
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Exec", this.Exec);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
        }
    }
}

