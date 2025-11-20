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

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance. You can call the [DescribeLoadBalancers](https://intl.cloud.tencent.com/document/product/214/30685?from_cn_redirect=1) API to obtain the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Ports for creating listeners. Each port corresponds to a listener.
        /// Port range: 1–65535.
        /// </summary>
        [JsonProperty("Ports")]
        public long?[] Ports{ get; set; }

        /// <summary>
        /// Listener protocol. Valid values: TCP, UDP, HTTP, HTTPS, TCP_SSL, and QUIC.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// List of names of listeners to be created. The names correspond to ports one by one. This parameter can be left blank if you do not want to name the listeners immediately.
        /// </summary>
        [JsonProperty("ListenerNames")]
        public string[] ListenerNames{ get; set; }

        /// <summary>
        /// Health check parameter. This parameter applies only to TCP, UDP, TCP_SSL, and QUIC listeners.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Certificate-related information. The parameter limitations are as follows:
        /// <li>This parameter applies only to TCP_SSL listeners and HTTPS listeners with the SNI feature disabled.</li>
        /// <li>Either this parameter or the MultiCertInfo parameter should be specified when you create a TCP_SSL listener or an HTTPS listener with the SNI feature disabled. You cannot specify them at the same time.</li>
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// Session persistence duration, in seconds. Value range: 30–3600. Default value: 0, indicating that session persistence is not enabled by default. This parameter applies only to TCP and UDP listeners.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Listener forwarding method. Valid values: WRR (weighted round-robin), LEAST_CONN (least connections), and IP_HASH (IP address hash).
        /// Default value: WRR. This parameter applies only to TCP, UDP, TCP_SSL, and QUIC listeners.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Whether to enable the SNI feature. This parameter applies only to HTTPS listeners. 0: disable; 1: enable.
        /// </summary>
        [JsonProperty("SniSwitch")]
        public long? SniSwitch{ get; set; }

        /// <summary>
        /// Real server type. NODE: ordinary node; TARGETGROUP: real server group. This parameter applies only to TCP and UDP listeners. For layer-7 listeners, set the type in forwarding rules.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Session persistence type. If this parameter is not specified or the value is set to NORMAL, the default session persistence type is used. QUIC_CID: perform session persistence based on QUIC connection ID. If the value is set to QUIC_CID, only the UDP protocol is supported. This parameter applies only to TCP and UDP listeners. For layer-7 listeners, set the type in forwarding rules. (If the value is set to QUIC_CID, the Protocol value should be UDP, the Scheduler value should be WRR, and only IPv4 addresses are supported.)
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// Whether to enable the persistent connection feature. This parameter applies only to HTTP and HTTPS listeners. 0: disable; 1: enable. This feature is disabled by default.
        /// Enable this feature with caution if the maximum number of connections is limited for real servers. This feature is in beta testing. To use it, submit a [beta testing application](https://intl.cloud.tencent.com/apply/p/tsodp6qm21?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public long? KeepaliveEnable{ get; set; }

        /// <summary>
        /// End port. This parameter is required for creating a listener with a port range. In this case, the input parameter Ports allows only one value to indicate the start port. To experience the port range feature, [submit a ticket for application](https://console.cloud.tencent.com/workorder/category).
        /// </summary>
        [JsonProperty("EndPort")]
        public ulong? EndPort{ get; set; }

        /// <summary>
        /// Whether to send an RST packet to the client when a listener is unbound from a real server. This parameter applies only to TCP listeners.
        /// </summary>
        [JsonProperty("DeregisterTargetRst")]
        public bool? DeregisterTargetRst{ get; set; }

        /// <summary>
        /// Certificate information. You can import multiple server certificates with different algorithms at the same time. The parameter limitations are as follows:
        /// <li>This parameter applies only to TCP_SSL listeners and HTTPS listeners with the SNI feature disabled.</li>
        /// <li>Either this parameter or the Certificate parameter should be specified when you create a TCP_SSL listener or an HTTPS listener with the SNI feature disabled. You cannot specify them at the same time.</li>
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }

        /// <summary>
        /// Maximum number of connections to a listener. Currently, this parameter applies only to TCP, UDP, TCP_SSL, and QUIC listeners of LCU-supported instances. If this parameter is not specified or the value is set to -1, the maximum number of connections is not limited. This parameter is not supported for classic network-based instances.
        /// </summary>
        [JsonProperty("MaxConn")]
        public long? MaxConn{ get; set; }

        /// <summary>
        /// Maximum number of new connections to a listener. Currently, this parameter applies only to TCP, UDP, TCP_SSL, and QUIC listeners of LCU-supported instances. If this parameter is not specified or the value is set to -1, the maximum number of new connections is not limited. This parameter is not supported for classic network-based instances.
        /// </summary>
        [JsonProperty("MaxCps")]
        public long? MaxCps{ get; set; }

        /// <summary>
        /// Idle connection timeout, in seconds. This parameter applies only to TCP listeners. Value range: 300–900 for shared instances and dedicated instances and 300–1980 for LCU-supported instances. To set a value, [submit a ticket for application](https://console.cloud.tencent.com/workorder/category).
        /// </summary>
        [JsonProperty("IdleConnectTimeout")]
        public long? IdleConnectTimeout{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProxyProtocol")]
        public bool? ProxyProtocol{ get; set; }

        /// <summary>
        /// Whether to enable SNAT. True: enable; False: disable.
        /// </summary>
        [JsonProperty("SnatEnable")]
        public bool? SnatEnable{ get; set; }

        /// <summary>
        /// End port of a listener with a port range. Range of the port: 2–65535.
        /// </summary>
        [JsonProperty("FullEndPorts")]
        public long?[] FullEndPorts{ get; set; }

        /// <summary>
        /// Whether to enable H2C for a private network HTTP listener. True: enable; False: disable.
        /// </summary>
        [JsonProperty("H2cSwitch")]
        public bool? H2cSwitch{ get; set; }

        /// <summary>
        /// Whether to disable SSL for TCP_SSL listeners. Dual-stack binding is still supported after SSL is disabled. True: disable; False: enable.
        /// </summary>
        [JsonProperty("SslCloseSwitch")]
        public bool? SslCloseSwitch{ get; set; }

        /// <summary>
        /// Data compression mode. Valid values: transparent (passthrough mode) and compatibility (compatibility mode).
        /// </summary>
        [JsonProperty("DataCompressMode")]
        public string DataCompressMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "ListenerNames.", this.ListenerNames);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "EndPort", this.EndPort);
            this.SetParamSimple(map, prefix + "DeregisterTargetRst", this.DeregisterTargetRst);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
            this.SetParamSimple(map, prefix + "MaxConn", this.MaxConn);
            this.SetParamSimple(map, prefix + "MaxCps", this.MaxCps);
            this.SetParamSimple(map, prefix + "IdleConnectTimeout", this.IdleConnectTimeout);
            this.SetParamSimple(map, prefix + "ProxyProtocol", this.ProxyProtocol);
            this.SetParamSimple(map, prefix + "SnatEnable", this.SnatEnable);
            this.SetParamArraySimple(map, prefix + "FullEndPorts.", this.FullEndPorts);
            this.SetParamSimple(map, prefix + "H2cSwitch", this.H2cSwitch);
            this.SetParamSimple(map, prefix + "SslCloseSwitch", this.SslCloseSwitch);
            this.SetParamSimple(map, prefix + "DataCompressMode", this.DataCompressMode);
        }
    }
}

