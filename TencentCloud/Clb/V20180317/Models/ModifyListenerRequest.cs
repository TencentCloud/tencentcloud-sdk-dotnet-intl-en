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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance. You can call the [DescribeLoadBalancers](https://intl.cloud.tencent.com/document/product/214/30685?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// ID of the CLB instance listener. You can call the [DescribeListeners](https://intl.cloud.tencent.com/document/product/214/30686?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// New listener name. The maximum length is 255 characters.
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Session persistence time in seconds. Value range: 30-3,600. The default value is 0, indicating that session persistence is not enabled. This parameter is applicable only to TCP/UDP listeners.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Health check parameter. It is only applicable only to TCP, UDP, TCP_SSL and QUIC listeners.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Certificate information. This parameter is only applicable to HTTPS/TCP_SSL/QUIC listeners. `Certificate` and `MultiCertInfo` cannot be both specified.
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// Listener forwarding method. Valid values: WRR (weighted round-robin), LEAST_CONN (least connections), and IP_HASH (IP address hash).
        /// They indicate weighted round-robin and least connections, respectively. Default value: WRR.
        /// Use cases: This applies to TCP/UDP/TCP_SSL/QUIC listeners. The balancing method for Layer-7 listeners should be modified in the forwarding rules.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Whether to enable the SNI feature. This parameter applies only to HTTPS listeners. The default value is 0, indicating disabled, and 1 indicates enabled. Note: The SNI feature can be enabled for listeners that have not enabled SNI, but cannot be disabled for listeners that have enabled SNI.
        /// </summary>
        [JsonProperty("SniSwitch")]
        public long? SniSwitch{ get; set; }

        /// <summary>
        /// Target backend type. `NODE`: A single node; `TARGETGROUP`: A target group.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Whether to enable the persistent connection feature. This parameter applies only to HTTP/HTTPS listeners.
        /// The default value is 0, indicating disabled, and 1 indicates enabled.
        /// 
        /// Enable this feature with caution if the maximum number of connections is limited for real servers. This feature is in beta testing. To use it, submit a [beta testing application](https://intl.cloud.tencent.com/apply/p/tsodp6qm21?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public long? KeepaliveEnable{ get; set; }

        /// <summary>
        /// Reschedules when unbinding real servers. only supported for TCP/UDP listeners. toggle on to enable this feature.
        /// </summary>
        [JsonProperty("DeregisterTargetRst")]
        public bool? DeregisterTargetRst{ get; set; }

        /// <summary>
        /// Session persistence type. NORMAL: default session persistence type; QUIC_CID: perform session persistence based on QUIC connection ID. If the value is set to QUIC_CID, only the UDP protocol is supported.
        /// Use cases: This applies to TCP/UDP/TCP_SSL/QUIC listeners.
        /// 
        /// Default value: NORMAL.
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// Certificate information. You can specify multiple server-side certificates with different algorithm types. This parameter is only applicable to HTTPS listeners with the SNI feature not enabled. `Certificate` and `MultiCertInfo` cannot be specified at the same time. 
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }

        /// <summary>
        /// Maximum number of concurrent connections at the listener level. This parameter is supported only for LCU-supported instances with TCP/UDP/TCP_SSL/QUIC listeners currently. Value range: 1 to the maximum number of concurrent connections for the instance specification. -1 indicates that no limit is set on the concurrent connections at the listener level. Classic network instances do not support this parameter.
        /// 
        /// Default value: -1, which indicates no limit.
        /// </summary>
        [JsonProperty("MaxConn")]
        public long? MaxConn{ get; set; }

        /// <summary>
        /// Maximum number of new connections at the listener level. This parameter is supported only for LCU-supported instances with TCP/UDP/TCP_SSL/QUIC listeners currently. Value range: 1 to the maximum number of new connections for the instance specification. -1 indicates that no limit is set on the new connections at the listener level. Classic network instances do not support this parameter.
        /// 
        /// Default value: -1, which indicates no limit.
        /// </summary>
        [JsonProperty("MaxCps")]
        public long? MaxCps{ get; set; }

        /// <summary>
        /// Specifies the idle connection timeout in seconds. this parameter applies only to TCP/UDP listeners. default value: 900 for TCP listeners and 300 for UDP listeners. value range: 10–900 for shared instances and dedicated instances and 10–1980 for lcu-supported instances. to set a value exceeding 1980, [submit a ticket application](https://console.cloud.tencent.com/workorder/category). the maximum settable value is 3600.
        /// </summary>
        [JsonProperty("IdleConnectTimeout")]
        public long? IdleConnectTimeout{ get; set; }

        /// <summary>
        /// Specifies whether PP is supported for TCP_SSL and QUIC.
        /// </summary>
        [JsonProperty("ProxyProtocol")]
        public bool? ProxyProtocol{ get; set; }

        /// <summary>
        /// Whether SNAT (source IP replacement) is enabled. valid values: True (enabled), False (disabled). disabled by default. note: when SnatEnable is enabled, the client source IP will be replaced, at this point the `pass through client source IP` option is disabled, and vice versa.
        /// </summary>
        [JsonProperty("SnatEnable")]
        public bool? SnatEnable{ get; set; }

        /// <summary>
        /// Data compression mode.
        /// </summary>
        [JsonProperty("DataCompressMode")]
        public string DataCompressMode{ get; set; }

        /// <summary>
        /// Reschedules when setting backend server weight to 0. only supported for TCP/UDP listeners. toggle on to enable this feature.
        /// </summary>
        [JsonProperty("RescheduleTargetZeroWeight")]
        public bool? RescheduleTargetZeroWeight{ get; set; }

        /// <summary>
        /// Reschedules when health check exceptions occur on real servers. only supported for TCP/UDP listeners. toggle on to enable this feature.
        /// </summary>
        [JsonProperty("RescheduleUnhealthy")]
        public bool? RescheduleUnhealthy{ get; set; }

        /// <summary>
        /// Reschedules when adding or removing backend servers. only supported for TCP/UDP listeners. toggle on to enable this feature.
        /// </summary>
        [JsonProperty("RescheduleExpandTarget")]
        public bool? RescheduleExpandTarget{ get; set; }

        /// <summary>
        /// Specifies the trigger start time for rescheduling. value range: 0-3600s. supported only by TCP/UDP listeners.
        /// </summary>
        [JsonProperty("RescheduleStartTime")]
        public long? RescheduleStartTime{ get; set; }

        /// <summary>
        /// Rescheduling trigger duration. valid values: 0-3600s. only TCP/UDP listeners support this.
        /// </summary>
        [JsonProperty("RescheduleInterval")]
        public long? RescheduleInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "DeregisterTargetRst", this.DeregisterTargetRst);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
            this.SetParamSimple(map, prefix + "MaxConn", this.MaxConn);
            this.SetParamSimple(map, prefix + "MaxCps", this.MaxCps);
            this.SetParamSimple(map, prefix + "IdleConnectTimeout", this.IdleConnectTimeout);
            this.SetParamSimple(map, prefix + "ProxyProtocol", this.ProxyProtocol);
            this.SetParamSimple(map, prefix + "SnatEnable", this.SnatEnable);
            this.SetParamSimple(map, prefix + "DataCompressMode", this.DataCompressMode);
            this.SetParamSimple(map, prefix + "RescheduleTargetZeroWeight", this.RescheduleTargetZeroWeight);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleExpandTarget", this.RescheduleExpandTarget);
            this.SetParamSimple(map, prefix + "RescheduleStartTime", this.RescheduleStartTime);
            this.SetParamSimple(map, prefix + "RescheduleInterval", this.RescheduleInterval);
        }
    }
}

