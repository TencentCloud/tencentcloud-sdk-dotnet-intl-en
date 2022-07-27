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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// Whether IPVS is enabled
        /// </summary>
        [JsonProperty("IPVS")]
        public bool? IPVS{ get; set; }

        /// <summary>
        /// Whether auto-scaling is enabled for nodes in the cluster (Enabling this function is not supported when you create a cluster)
        /// </summary>
        [JsonProperty("AsEnabled")]
        public bool? AsEnabled{ get; set; }

        /// <summary>
        /// Type of runtime component used by the cluster. The types include "docker" and "containerd". Default value: docker
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// NodeName type for a node in a cluster (This includes the two forms of **hostname** and **lan-ip**, with the default as **lan-ip**. If **hostname** is used, you need to set the HostName parameter when creating a node, and the InstanceName needs to be the same as the HostName.)
        /// </summary>
        [JsonProperty("NodeNameType")]
        public string NodeNameType{ get; set; }

        /// <summary>
        /// Cluster custom parameter
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public ClusterExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// Cluster network type, which can be GR (Global Router) or VPC-CNI. The default value is GR.
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// Whether a cluster in VPC-CNI mode uses dynamic IP addresses. The default value is FALSE, which indicates that static IP addresses are used.
        /// </summary>
        [JsonProperty("IsNonStaticIpMode")]
        public bool? IsNonStaticIpMode{ get; set; }

        /// <summary>
        /// Indicates whether to enable cluster deletion protection.
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// Cluster network proxy model, which is only used when ipvs-bpf mode is used. At present, TKE cluster supports three network proxy modes including `iptables`, `ipvs` and `ipvs-bpf` and their parameter setting relationships are as follows:
        /// `iptables`: do not set IPVS and KubeProxyMode.
        /// `ipvs`: set IPVS to `true` and do not set KubeProxyMode.
        /// `ipvs-bpf`: set KubeProxyMode to `kube-proxy-bpf`.
        /// The following conditions are required to use ipvs-bpf network mode:
        /// 1. The cluster version must be v1.14 or later.
        /// 2. The system image must be Tencent Linux 2.4.
        /// </summary>
        [JsonProperty("KubeProxyMode")]
        public string KubeProxyMode{ get; set; }

        /// <summary>
        /// Indicates whether to enable auditing
        /// </summary>
        [JsonProperty("AuditEnabled")]
        public bool? AuditEnabled{ get; set; }

        /// <summary>
        /// Specifies the ID of logset to which the audit logs are uploaded.
        /// </summary>
        [JsonProperty("AuditLogsetId")]
        public string AuditLogsetId{ get; set; }

        /// <summary>
        /// Specifies the ID of topic to which the audit logs are uploaded.
        /// </summary>
        [JsonProperty("AuditLogTopicId")]
        public string AuditLogTopicId{ get; set; }

        /// <summary>
        /// Specifies the ENI type. Values: `tke-route-eni` (multi-IP shared ENI); `tke-direct-eni` (independent ENI). It defaults to `tke-route-eni`.
        /// </summary>
        [JsonProperty("VpcCniType")]
        public string VpcCniType{ get; set; }

        /// <summary>
        /// Runtime version
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// Indicates whether to enable the custom mode for the node’s pod CIDR range
        /// </summary>
        [JsonProperty("EnableCustomizedPodCIDR")]
        public bool? EnableCustomizedPodCIDR{ get; set; }

        /// <summary>
        /// The basic number of Pods in custom mode
        /// </summary>
        [JsonProperty("BasePodNumber")]
        public long? BasePodNumber{ get; set; }

        /// <summary>
        /// Specifies whether to enable Cilium. If it’s left empty, Cilium is not enabled. If `clusterIP` is passed in, it means to enable Cilium to support the clusterIP service type.
        /// </summary>
        [JsonProperty("CiliumMode")]
        public string CiliumMode{ get; set; }

        /// <summary>
        /// Whether it is a dual-stack cluster in VPC-CNI mode. Default value: `false`, which indicates it is not a dual-stack cluster.
        /// </summary>
        [JsonProperty("IsDualStack")]
        public bool? IsDualStack{ get; set; }

        /// <summary>
        /// Whether to enable qGPU Sharing
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPVS", this.IPVS);
            this.SetParamSimple(map, prefix + "AsEnabled", this.AsEnabled);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "NodeNameType", this.NodeNameType);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "IsNonStaticIpMode", this.IsNonStaticIpMode);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "KubeProxyMode", this.KubeProxyMode);
            this.SetParamSimple(map, prefix + "AuditEnabled", this.AuditEnabled);
            this.SetParamSimple(map, prefix + "AuditLogsetId", this.AuditLogsetId);
            this.SetParamSimple(map, prefix + "AuditLogTopicId", this.AuditLogTopicId);
            this.SetParamSimple(map, prefix + "VpcCniType", this.VpcCniType);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "EnableCustomizedPodCIDR", this.EnableCustomizedPodCIDR);
            this.SetParamSimple(map, prefix + "BasePodNumber", this.BasePodNumber);
            this.SetParamSimple(map, prefix + "CiliumMode", this.CiliumMode);
            this.SetParamSimple(map, prefix + "IsDualStack", this.IsDualStack);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
        }
    }
}

