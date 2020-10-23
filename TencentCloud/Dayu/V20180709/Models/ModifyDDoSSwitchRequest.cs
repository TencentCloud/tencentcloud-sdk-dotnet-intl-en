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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `basic`: Anti-DDoS Basic
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// `get`: read DDoS protection status, `set`: modify DDoS protection status
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Anti-DDoS Basic IP, which is required only if `Business` is Anti-DDoS Basic;
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Product type of IP, which is required only if `Business` is Anti-DDoS Basic. Valid values: [public (CVM), bm (BM), eni (ENI), vpngw (VPN Gateway), natgw (NAT Gateway), waf (WAF), fpc (finance product), gaap (GAAP), other (hosted IP)]
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// Product subtype of IP, which is required only if `Business` is Anti-DDoS Basic. Valid values: [cvm (CVM), lb (CLB), eni (ENI), vpngw (VPN), natgw (NAT), waf (WAF), fpc (finance), gaap (GAAP), other (hosted IP), eip (BM EIP)]
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Resource instance ID of IP, which is required only if `Business` is Anti-DDoS Basic. This field is required when binding a new IP. For example, if it is an ENI IP, enter `ID(eni-*)` of the ENI for `InstanceId`;
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// This field is required only if `Business` is Anti-DDoS Basic, indicating the IP region. Valid values:
        /// "bj":     North China (Beijing)
        /// "cd":     Southwest China (Chengdu)
        /// "cq":     Southwest China (Chongqing)
        /// "gz":     South China (Guangzhou)
        /// "gzopen": South China (Guangzhou Open)
        /// "hk":     Hong Kong (China)
        /// "kr":     Southeast Asia (Seoul)
        /// "sh":     East China (Shanghai)
        /// "shjr":   East China (Shanghai Finance)
        /// "szjr":   South China (Shenzhen Finance)
        /// "sg":     Southeast Asia (Singapore)
        /// "th":     Southeast Asia (Thailand)
        /// "de":     Europe (Germany)
        /// "usw":    West US (Silicon Valley)
        /// "ca":     North America (Toronto)
        /// "jp":     Japan
        /// "hzec":   Hangzhou
        /// "in":     India
        /// "use":    East US (Virginia)
        /// "ru":     Russia
        /// "tpe":    Taiwan (China)
        /// "nj":     Nanjing
        /// </summary>
        [JsonProperty("IPRegion")]
        public string IPRegion{ get; set; }

        /// <summary>
        /// Protection status value, which is optional. Valid values: [0 (disabled), 1 (enabled)]. If `Method` is `get`, this field can be left empty;
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IPRegion", this.IPRegion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

