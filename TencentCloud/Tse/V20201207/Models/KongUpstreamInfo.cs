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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongUpstreamInfo : AbstractModel
    {
        
        /// <summary>
        /// IP or domain
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Service source ID
        /// </summary>
        [JsonProperty("SourceID")]
        public string SourceID{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Service (registration center or service in Kubernetes) name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// The backend type is IPList when provided by the service
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Targets")]
        public KongTarget[] Targets{ get; set; }

        /// <summary>
        /// Service source type
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// SCF Function Type
        /// </summary>
        [JsonProperty("ScfType")]
        public string ScfType{ get; set; }

        /// <summary>
        /// SCF function namespace
        /// </summary>
        [JsonProperty("ScfNamespace")]
        public string ScfNamespace{ get; set; }

        /// <summary>
        /// SCF Function Name
        /// </summary>
        [JsonProperty("ScfLambdaName")]
        public string ScfLambdaName{ get; set; }

        /// <summary>
        /// SCF Function Version
        /// </summary>
        [JsonProperty("ScfLambdaQualifier")]
        public string ScfLambdaQualifier{ get; set; }

        /// <summary>
        /// Cold start time, in seconds
        /// </summary>
        [JsonProperty("SlowStart")]
        public long? SlowStart{ get; set; }

        /// <summary>
        /// Load balancing algorithm, defaults to round-robin, also supports least-connections, consisten_hashing
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// Auto scaling group ID of CVM
        /// </summary>
        [JsonProperty("AutoScalingGroupID")]
        public string AutoScalingGroupID{ get; set; }

        /// <summary>
        /// CVM auto scaling group port
        /// </summary>
        [JsonProperty("AutoScalingCvmPort")]
        public ulong? AutoScalingCvmPort{ get; set; }

        /// <summary>
        /// TAT command status of the CVM used in the auto scaling group
        /// </summary>
        [JsonProperty("AutoScalingTatCmdStatus")]
        public string AutoScalingTatCmdStatus{ get; set; }

        /// <summary>
        /// CVM auto scaling group lifecycle hook status
        /// </summary>
        [JsonProperty("AutoScalingHookStatus")]
        public string AutoScalingHookStatus{ get; set; }

        /// <summary>
        /// Service source name.
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// Precise service source type. Type passed in when creating a service source.
        /// </summary>
        [JsonProperty("RealSourceType")]
        public string RealSourceType{ get; set; }

        /// <summary>
        /// upstream health status HEALTHY (healthy), UNHEALTHY (abnormal), HEALTHCHECKS_OFF (not enabled), and NONE (health checks not supported)
        /// </summary>
        [JsonProperty("HealthStatus")]
        public string HealthStatus{ get; set; }

        /// <summary>
        /// Whether CAM authentication is enabled for SCF. Enabled by default (true) when left blank.
        /// </summary>
        [JsonProperty("ScfCamAuthEnable")]
        public bool? ScfCamAuthEnable{ get; set; }

        /// <summary>
        /// Whether Base64 encoding is enabled for SCF, default false
        /// </summary>
        [JsonProperty("ScfIsBase64Encoded")]
        public bool? ScfIsBase64Encoded{ get; set; }

        /// <summary>
        /// Whether response integration is enabled for the cloud function, default false
        /// </summary>
        [JsonProperty("ScfIsIntegratedResponse")]
        public bool? ScfIsIntegratedResponse{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "SourceID", this.SourceID);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ScfType", this.ScfType);
            this.SetParamSimple(map, prefix + "ScfNamespace", this.ScfNamespace);
            this.SetParamSimple(map, prefix + "ScfLambdaName", this.ScfLambdaName);
            this.SetParamSimple(map, prefix + "ScfLambdaQualifier", this.ScfLambdaQualifier);
            this.SetParamSimple(map, prefix + "SlowStart", this.SlowStart);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "AutoScalingGroupID", this.AutoScalingGroupID);
            this.SetParamSimple(map, prefix + "AutoScalingCvmPort", this.AutoScalingCvmPort);
            this.SetParamSimple(map, prefix + "AutoScalingTatCmdStatus", this.AutoScalingTatCmdStatus);
            this.SetParamSimple(map, prefix + "AutoScalingHookStatus", this.AutoScalingHookStatus);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "RealSourceType", this.RealSourceType);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "ScfCamAuthEnable", this.ScfCamAuthEnable);
            this.SetParamSimple(map, prefix + "ScfIsBase64Encoded", this.ScfIsBase64Encoded);
            this.SetParamSimple(map, prefix + "ScfIsIntegratedResponse", this.ScfIsIntegratedResponse);
        }
    }
}

