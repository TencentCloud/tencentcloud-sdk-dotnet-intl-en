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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDealsGoodsDetail : AbstractModel
    {
        
        /// <summary>
        /// Time interval
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Unit, support for purchasing d, m, y, i.e., (day, month, year)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Sub-product tag. It is mandatory for new purchase and renewal. For configuration change, it will be placed in oldConfig and newConfig.
        /// 
        /// SaaS Advanced Edition: sp_wsm_waf_premium
        /// SaaS Enterprise Edition: sp_wsm_waf_enterprise
        /// SaaS Ultimate Edition: sp_wsm_waf_ultimate
        /// SaaS business expansion package: sp_wsm_waf_qpsep
        /// SaaS domain name expansion package: sp_wsm_waf_domain
        /// 
        /// Advanced Edition - CLB: sp_wsm_waf_premium_clb
        /// Enterprise Edition - CLB: sp_wsm_waf_enterprise_clb
        /// Ultimate Edition - CLB: sp_wsm_waf_ultimate_clb
        ///  business expansion package - CLB: sp_wsm_waf_qpsep_clb
        /// Domain name expansion package - CLB: sp_wsm_waf_domain_clb
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// PID applied for a business product (corresponding to a pricing formula). The pricing model can be found through PID billing.
        /// Advanced Edition: 1000827
        /// Enterprise Edition: 1000830
        /// Ultimate Edition: 1000832
        /// Domain name package: 1000834
        /// Business expansion package: 1000481
        /// Advanced Edition - CLB: 1001150
        /// Enterprise Edition - CLB: 1001152
        /// Ultimate Edition - CLB: 1001154
        /// Domain name package - CLB: 1001156
        /// Business expansion package - CLB: 1001160
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// WAF Instance Name
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 1: Auto-renewal, 0: No Auto-renewal
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Actual Geographic Information of WAF Purchase
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealRegion")]
        public long? RealRegion{ get; set; }

        /// <summary>
        /// Billing Detail Tag Array
        /// 
        /// SaaS Advanced Edition: sv_wsm_waf_package_premium
        /// SaaS Enterprise Edition: sv_wsm_waf_package_enterprise
        /// SaaS Ultimate Edition: sv_wsm_waf_package_ultimate
        /// SaaS non-Chinese Mainland Advanced Edition: sv_wsm_waf_package_premium_intl
        /// SaaS non-Chinese Mainland Enterprise Edition: sv_wsm_waf_package_enterprise_intl
        /// SaaS non-Chinese Mainland Ultimate Edition: sv_wsm_waf_package_ultimate_intl
        /// SaaS business expansion package: sv_wsm_waf_qps_ep
        /// SaaS domain name expansion package: sv_wsm_waf_domain
        /// 
        /// Advanced Edition CLB: sv_wsm_waf_package_premium_clb
        /// Enterprise Edition CLB: sv_wsm_waf_package_enterprise_clb
        /// Ultimate Edition CLB: sv_wsm_waf_package_ultimate_clb
        /// Non-Chinese Mainland Advanced Edition CLB: sv_wsm_waf_package_premium_clb_intl
        /// Non-Chinese Mainland Enterprise Edition CLB: sv_wsm_waf_package_premium_clb_intl
        /// Non-Chinese Mainland Ultimate Edition CLB: sv_wsm_waf_package_ultimate_clb_intl
        /// Business expansion package CLB: sv_wsm_waf_qps_ep_clb
        /// Domain name expansion package CLB: sv_wsm_waf_domain_clb
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LabelTypes")]
        public string[] LabelTypes{ get; set; }

        /// <summary>
        /// Number of Billing Detail Tags, Generally Corresponds One-to-One with SvLabelType
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LabelCounts")]
        public long?[] LabelCounts{ get; set; }

        /// <summary>
        /// Dynamic Configuration Usage, Instance Expiration Time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// Purchasing Bot or API Security for Existing Instances
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Resource ID
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "RealRegion", this.RealRegion);
            this.SetParamArraySimple(map, prefix + "LabelTypes.", this.LabelTypes);
            this.SetParamArraySimple(map, prefix + "LabelCounts.", this.LabelCounts);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

