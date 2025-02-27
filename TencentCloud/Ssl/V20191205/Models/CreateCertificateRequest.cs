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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// Certificate product id. `3`: securesite ev pro; `4`: securesite ev; `5`: securesite ov pro; `6`: securesite ov; `7`: securesite ov wildcard; `8`: geotrust ev; `9`: geotrust ov; `10`: geotrust ov wildcard; `11`: trustasia dv multi-domain; `12`: trustasia dv wildcard; `13`: trustasia ov wildcard d3; `14`: trustasia ov d3; `15`: trustasia ov multi-domain d3; `16`: trustasia ev d3; `17`: trustasia ev multi-domain d3; `18`: globalsign ov; `19`: globalsign ov wildcard; `20`: globalsign ev; `21`: trustasia ov wildcard multi-domain d3; `22`: globalsign ov multi-domain; `23`: globalsign ov wildcard multi-domain; `24`: globalsign ev multi-domain; `25`: wotrus dv; `26`: wotrus dv multi-domain; `27`: wotrus dv wildcard; `28`: wotrus ov; `29`: wotrus ov multi-domain; `30`: wotrus ov wildcard; `31`: wotrus ev; `32`: wotrus ev multi-domain; `33`: DNSPod sm2 dv; `34`: DNSPod sm2 dv multi-domain; `35`: DNSPod sm2 dv wildcard; `37`: DNSPod sm2 ov; `38`: DNSPod sm2 ov multi-domain; `39`: DNSPod sm2 ov wildcard; `40`: DNSPod sm2 ev; `41`: DNSPod sm2 ev multi-domain; `42`: trustasia dv wildcard multi-domain; `43`: dnspod-ov ssl certificate; `44`: dnspod-ov wildcard ssl certificate; `45`: dnspod-ov multi-domain ssl certificate; `46`: dnspod-ev ssl certificate; `47`: dnspod-ev multi-domain ssl certificate; `48`: dnspod-dv ssl certificate; `49`: dnspod-dv wildcard ssl certificate; `50`: dnspod-dv multi-domain ssl certificate; `51`: DNSPod (sm2)-ov ssl certificate; `52`: DNSPod (sm2)-ov wildcard ssl certificate; `53`: DNSPod (sm2)-ov multi-domain ssl certificate; `54`: DNSPod (sm2)-dv ssl certificate; `55`: DNSPod (sm2)-dv wildcard ssl certificate; `56`: DNSPod (sm2)-dv multi-domain ssl certificate; `57`: securesite ov pro multi-domain; `58`: securesite ov multi-domain; `59`: securesite ev pro multi-domain; `60`: securesite ev multi-domain; `61`: geotrust ev multi-domain.
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// Number of domains associated with the certificate
        /// </summary>
        [JsonProperty("DomainNum")]
        public long? DomainNum{ get; set; }

        /// <summary>
        /// Certificate validity period.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Whether to automatically use vouchers: 1 for yes, 0 for no; the default is 1.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Tag, generate tags for certificates.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DomainNum", this.DomainNum);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

