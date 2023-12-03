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

    public class DescribeCertificateBindResourceTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// The details of associated CLB resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CLB")]
        public ClbInstanceList[] CLB{ get; set; }

        /// <summary>
        /// The details of associated CDN resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CDN")]
        public CdnInstanceList[] CDN{ get; set; }

        /// <summary>
        /// The details of associated WAF resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WAF")]
        public WafInstanceList[] WAF{ get; set; }

        /// <summary>
        /// The details of associated Anti-DDS resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDOS")]
        public DdosInstanceList[] DDOS{ get; set; }

        /// <summary>
        /// The details of associated LIVE resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LIVE")]
        public LiveInstanceList[] LIVE{ get; set; }

        /// <summary>
        /// The details of associated VOD resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VOD")]
        public VODInstanceList[] VOD{ get; set; }

        /// <summary>
        /// The details of associated TKE resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TKE")]
        public TkeInstanceList[] TKE{ get; set; }

        /// <summary>
        /// The details of associated APIGATEWAY resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("APIGATEWAY")]
        public ApiGatewayInstanceList[] APIGATEWAY{ get; set; }

        /// <summary>
        /// The details of associated TCB resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TCB")]
        public TCBInstanceList[] TCB{ get; set; }

        /// <summary>
        /// The details of associated TEO resources.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TEO")]
        public TeoInstanceList[] TEO{ get; set; }

        /// <summary>
        /// The status of the async task. Valid values: `0` for querying, `1` for successful, and `2` for abnormal. If the status is `1`, the result of `BindResourceResult` will be displayed; if the status is `2`, the error causes will be displayed.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// The cache time of the current result.
        /// </summary>
        [JsonProperty("CacheTime")]
        public string CacheTime{ get; set; }

        /// <summary>
        /// Associated TSE resource details
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TSE")]
        public TSEInstanceList[] TSE{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CLB.", this.CLB);
            this.SetParamArrayObj(map, prefix + "CDN.", this.CDN);
            this.SetParamArrayObj(map, prefix + "WAF.", this.WAF);
            this.SetParamArrayObj(map, prefix + "DDOS.", this.DDOS);
            this.SetParamArrayObj(map, prefix + "LIVE.", this.LIVE);
            this.SetParamArrayObj(map, prefix + "VOD.", this.VOD);
            this.SetParamArrayObj(map, prefix + "TKE.", this.TKE);
            this.SetParamArrayObj(map, prefix + "APIGATEWAY.", this.APIGATEWAY);
            this.SetParamArrayObj(map, prefix + "TCB.", this.TCB);
            this.SetParamArrayObj(map, prefix + "TEO.", this.TEO);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
            this.SetParamArrayObj(map, prefix + "TSE.", this.TSE);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

