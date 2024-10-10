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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Resource ID corresponding to the Instance, for billing usage
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string ResourceIds{ get; set; }

        /// <summary>
        /// Instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Auto-renewal flag.
        /// 
        /// 0: disable
        /// 
        /// 1: enable
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// Elastic billing switch.
        /// 0: disable
        /// 
        /// 1: enable
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Instance package version.
        /// 101: Small and Micro Edition.
        /// 102: Ultra-light Edition.
        /// 2: Advanced Edition.
        /// 3: Enterprise Edition.
        /// 4: Ultimate Edition.
        /// 6: Exclusive Edition
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Instance expiration time
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// Instance Start Time
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Configured Domain Count
        /// </summary>
        [JsonProperty("DomainCount")]
        public ulong? DomainCount{ get; set; }

        /// <summary>
        /// Maximum Domain Count
        /// </summary>
        [JsonProperty("SubDomainLimit")]
        public ulong? SubDomainLimit{ get; set; }

        /// <summary>
        /// Configured Primary Domain Count
        /// </summary>
        [JsonProperty("MainDomainCount")]
        public ulong? MainDomainCount{ get; set; }

        /// <summary>
        /// Maximum Number of Primary Domain Names
        /// </summary>
        [JsonProperty("MainDomainLimit")]
        public ulong? MainDomainLimit{ get; set; }

        /// <summary>
        /// Instance QPS Peak within 30 Days
        /// </summary>
        [JsonProperty("MaxQPS")]
        public ulong? MaxQPS{ get; set; }

        /// <summary>
        /// QPS Expansion Package Information
        /// </summary>
        [JsonProperty("QPS")]
        public QPSPackageNew QPS{ get; set; }

        /// <summary>
        /// Domain Extension Package Information
        /// </summary>
        [JsonProperty("DomainPkg")]
        public DomainPackageNew DomainPkg{ get; set; }

        /// <summary>
        /// User appid.
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// CLB or SaaS
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// Business Security Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FraudPkg")]
        public FraudPkg FraudPkg{ get; set; }

        /// <summary>
        /// Bot Resource Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BotPkg")]
        public BotPkg BotPkg{ get; set; }

        /// <summary>
        /// Bot's QPS details
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BotQPS")]
        public BotQPS BotQPS{ get; set; }

        /// <summary>
        /// QPS Elastic Billing Cap
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ElasticBilling")]
        public ulong? ElasticBilling{ get; set; }

        /// <summary>
        /// Attack Log Shipping Switch
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackLogPost")]
        public long? AttackLogPost{ get; set; }

        /// <summary>
        /// Peak Bandwidth, in B/s (Bytes per Second)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public ulong? MaxBandwidth{ get; set; }

        /// <summary>
        /// Whether API security is purchased
        /// </summary>
        [JsonProperty("APISecurity")]
        public ulong? APISecurity{ get; set; }

        /// <summary>
        /// Purchased QPS Specification
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QpsStandard")]
        public ulong? QpsStandard{ get; set; }

        /// <summary>
        /// Purchased Bandwidth Specification
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BandwidthStandard")]
        public ulong? BandwidthStandard{ get; set; }

        /// <summary>
        /// Instance status
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Instance Sandbox QPS Value
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SandboxQps")]
        public ulong? SandboxQps{ get; set; }

        /// <summary>
        /// Whether API Security is on Trial
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAPISecurityTrial")]
        public ulong? IsAPISecurityTrial{ get; set; }

        /// <summary>
        /// Premium Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MajorEventsPkg")]
        public MajorEventsPkg MajorEventsPkg{ get; set; }

        /// <summary>
        /// Hybrid Cloud Sub-node Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HybridPkg")]
        public HybridPkg HybridPkg{ get; set; }

        /// <summary>
        /// API security resource package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiPkg")]
        public ApiPkg ApiPkg{ get; set; }

        /// <summary>
        /// MMPS Acceleration Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MiniPkg")]
        public MiniPkg MiniPkg{ get; set; }

        /// <summary>
        /// Mini Program QPS Specification
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MiniQpsStandard")]
        public ulong? MiniQpsStandard{ get; set; }

        /// <summary>
        /// Mini Program QPS Peak
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MiniMaxQPS")]
        public ulong? MiniMaxQPS{ get; set; }

        /// <summary>
        /// Last overage time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastQpsExceedTime")]
        public string LastQpsExceedTime{ get; set; }

        /// <summary>
        /// ID quantity expansion package for secure mini program access.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MiniExtendPkg")]
        public MiniExtendPkg MiniExtendPkg{ get; set; }

        /// <summary>
        /// Billing item.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// Flag for delay of instance deletion.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FreeDelayFlag")]
        public ulong? FreeDelayFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ResourceIds", this.ResourceIds);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "SubDomainLimit", this.SubDomainLimit);
            this.SetParamSimple(map, prefix + "MainDomainCount", this.MainDomainCount);
            this.SetParamSimple(map, prefix + "MainDomainLimit", this.MainDomainLimit);
            this.SetParamSimple(map, prefix + "MaxQPS", this.MaxQPS);
            this.SetParamObj(map, prefix + "QPS.", this.QPS);
            this.SetParamObj(map, prefix + "DomainPkg.", this.DomainPkg);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamObj(map, prefix + "FraudPkg.", this.FraudPkg);
            this.SetParamObj(map, prefix + "BotPkg.", this.BotPkg);
            this.SetParamObj(map, prefix + "BotQPS.", this.BotQPS);
            this.SetParamSimple(map, prefix + "ElasticBilling", this.ElasticBilling);
            this.SetParamSimple(map, prefix + "AttackLogPost", this.AttackLogPost);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "APISecurity", this.APISecurity);
            this.SetParamSimple(map, prefix + "QpsStandard", this.QpsStandard);
            this.SetParamSimple(map, prefix + "BandwidthStandard", this.BandwidthStandard);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SandboxQps", this.SandboxQps);
            this.SetParamSimple(map, prefix + "IsAPISecurityTrial", this.IsAPISecurityTrial);
            this.SetParamObj(map, prefix + "MajorEventsPkg.", this.MajorEventsPkg);
            this.SetParamObj(map, prefix + "HybridPkg.", this.HybridPkg);
            this.SetParamObj(map, prefix + "ApiPkg.", this.ApiPkg);
            this.SetParamObj(map, prefix + "MiniPkg.", this.MiniPkg);
            this.SetParamSimple(map, prefix + "MiniQpsStandard", this.MiniQpsStandard);
            this.SetParamSimple(map, prefix + "MiniMaxQPS", this.MiniMaxQPS);
            this.SetParamSimple(map, prefix + "LastQpsExceedTime", this.LastQpsExceedTime);
            this.SetParamObj(map, prefix + "MiniExtendPkg.", this.MiniExtendPkg);
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
            this.SetParamSimple(map, prefix + "FreeDelayFlag", this.FreeDelayFlag);
        }
    }
}

