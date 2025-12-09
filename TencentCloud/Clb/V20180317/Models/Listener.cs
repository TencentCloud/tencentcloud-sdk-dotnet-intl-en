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

    public class Listener : AbstractModel
    {
        
        /// <summary>
        /// CLB listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Listener protocol. valid values: TCP, UDP, HTTP, HTTPS, TCP_SSL, QUIC.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Listener port. value range: 1-65535.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Information of certificates bound to the listener
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateOutput Certificate{ get; set; }

        /// <summary>
        /// Health check information of the listener
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Request scheduling method. WRR, LEAST_CONN, and IP_HASH respectively indicate weighted round robin, least connections, and IP hash.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Session persistence time, in seconds. value range: 30-3600. default value: 0, indicating that session persistence is not enabled by default. this parameter applies only to TCP and UDP listeners.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Specifies whether to enable the SNI feature. 1: enable; 0: disable. this parameter is applicable only to HTTPS listeners.
        /// </summary>
        [JsonProperty("SniSwitch")]
        public long? SniSwitch{ get; set; }

        /// <summary>
        /// All forwarding rules under a listener (this parameter is meaningful only for HTTP/HTTPS listeners)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Rules")]
        public RuleOutput[] Rules{ get; set; }

        /// <summary>
        /// Listener name
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Listener creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// End port of the port range. value range: 2-65535.
        /// </summary>
        [JsonProperty("EndPort")]
        public long? EndPort{ get; set; }

        /// <summary>
        /// Backend server type. available values: NODE, POLARIS, TARGETGROUP, TARGETGROUP-V2.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Basic information of a bound target group. This field will be returned when a target group is bound to a listener.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetGroup")]
        public BasicTargetGroupInfo TargetGroup{ get; set; }

        /// <summary>
        /// Session persistence type. NORMAL: Default session persistence type; QUIC_CID: Session persistence by Quic Connection ID.
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// Whether a persistent connection is enabled (1: enabled; 0: disabled). This parameter can only be configured in HTTP/HTTPS listeners.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public long? KeepaliveEnable{ get; set; }

        /// <summary>
        /// Supports Nat64 CLB TCP listeners only
        /// </summary>
        [JsonProperty("Toa")]
        public bool? Toa{ get; set; }

        /// <summary>
        /// Reschedules when unbinding real servers. only supported for TCP/UDP listeners. toggle on to enable this feature.
        /// </summary>
        [JsonProperty("DeregisterTargetRst")]
        public bool? DeregisterTargetRst{ get; set; }

        /// <summary>
        /// Describes the attributes of the listener.
        /// </summary>
        [JsonProperty("AttrFlags")]
        public string[] AttrFlags{ get; set; }

        /// <summary>
        /// List of bound target groups
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetGroupList")]
        public BasicTargetGroupInfo[] TargetGroupList{ get; set; }

        /// <summary>
        /// Maximum number of connections to a listener. -1 indicates unlimited speed at the listener dimension.
        /// </summary>
        [JsonProperty("MaxConn")]
        public long? MaxConn{ get; set; }

        /// <summary>
        /// Maximum number of new connections to a listener. -1 means no speed limit at the listener dimension.
        /// </summary>
        [JsonProperty("MaxCps")]
        public long? MaxCps{ get; set; }

        /// <summary>
        /// Connection idle timeout period (in seconds). It’s only available to TCP listeners. Value range: 300-900 for shared and dedicated instances; 300-2000 for LCU-supported CLB instances. It defaults to 900.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdleConnectTimeout")]
        public long? IdleConnectTimeout{ get; set; }

        /// <summary>
        /// Rescheduling trigger duration, valid values: 0-3600s. only TCP/UDP listeners support this. after triggering rescheduling, persistent connections will disconnect and be reassigned within the set scheduling time.
        /// </summary>
        [JsonProperty("RescheduleInterval")]
        public ulong? RescheduleInterval{ get; set; }

        /// <summary>
        /// Data compression mode.
        /// </summary>
        [JsonProperty("DataCompressMode")]
        public string DataCompressMode{ get; set; }

        /// <summary>
        /// Reschedules the startup time. when configured, rescheduling will be triggered upon arrival of the start time.
        /// </summary>
        [JsonProperty("RescheduleStartTime")]
        public long? RescheduleStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndPort", this.EndPort);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamObj(map, prefix + "TargetGroup.", this.TargetGroup);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "Toa", this.Toa);
            this.SetParamSimple(map, prefix + "DeregisterTargetRst", this.DeregisterTargetRst);
            this.SetParamArraySimple(map, prefix + "AttrFlags.", this.AttrFlags);
            this.SetParamArrayObj(map, prefix + "TargetGroupList.", this.TargetGroupList);
            this.SetParamSimple(map, prefix + "MaxConn", this.MaxConn);
            this.SetParamSimple(map, prefix + "MaxCps", this.MaxCps);
            this.SetParamSimple(map, prefix + "IdleConnectTimeout", this.IdleConnectTimeout);
            this.SetParamSimple(map, prefix + "RescheduleInterval", this.RescheduleInterval);
            this.SetParamSimple(map, prefix + "DataCompressMode", this.DataCompressMode);
            this.SetParamSimple(map, prefix + "RescheduleStartTime", this.RescheduleStartTime);
        }
    }
}

