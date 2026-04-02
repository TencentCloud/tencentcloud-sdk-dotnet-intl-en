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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataPerformancePageV2Request : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// pagepv: PV view. allcount: performance view. falls: page loading waterfall chart. samp: first meaningful paint. day: 14-day data. nettype: network or platform view. performance: top page performance view. version/platform/isp/region/device/browser/ext1/ext2/ext3/ret/status/from/url/env/: ISP view, region view, browser view, and so on.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Log level.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Internet service provider.
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Network type.
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// Platform.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Model.
        /// </summary>
        [JsonProperty("Device")]
        public string Device{ get; set; }

        /// <summary>
        /// Version.
        /// </summary>
        [JsonProperty("VersionNum")]
        public string VersionNum{ get; set; }

        /// <summary>
        /// Custom parameter 1.
        /// </summary>
        [JsonProperty("ExtFirst")]
        public string ExtFirst{ get; set; }

        /// <summary>
        /// Custom parameter 2.
        /// </summary>
        [JsonProperty("ExtSecond")]
        public string ExtSecond{ get; set; }

        /// <summary>
        /// Custom parameter 3.
        /// </summary>
        [JsonProperty("ExtThird")]
        public string ExtThird{ get; set; }

        /// <summary>
        /// Indicates whether to query global data. 1 indicates global. 0 indicates not global. This is empty by default, which means to query all data.
        /// </summary>
        [JsonProperty("IsAbroad")]
        public string IsAbroad{ get; set; }

        /// <summary>
        /// Browser.
        /// </summary>
        [JsonProperty("Browser")]
        public string Browser{ get; set; }

        /// <summary>
        /// Operating system.
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// Browser engine.
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Brand.
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// Source page.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Duration calculation method.
        /// </summary>
        [JsonProperty("CostType")]
        public string CostType{ get; set; }

        /// <summary>
        /// Environment variable.
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// Network status.
        /// </summary>
        [JsonProperty("NetStatus")]
        public string NetStatus{ get; set; }

        /// <summary>
        /// Indicates whether to return webvitals data.
        /// </summary>
        [JsonProperty("WebVitals")]
        public bool? WebVitals{ get; set; }

        /// <summary>
        /// Custom parameter 4.
        /// </summary>
        [JsonProperty("ExtFourth")]
        public string ExtFourth{ get; set; }

        /// <summary>
        /// Custom parameter 5.
        /// </summary>
        [JsonProperty("ExtFifth")]
        public string ExtFifth{ get; set; }

        /// <summary>
        /// Custom parameter 6.
        /// </summary>
        [JsonProperty("ExtSixth")]
        public string ExtSixth{ get; set; }

        /// <summary>
        /// Custom parameter 7.
        /// </summary>
        [JsonProperty("ExtSeventh")]
        public string ExtSeventh{ get; set; }

        /// <summary>
        /// Custom parameter 8.
        /// </summary>
        [JsonProperty("ExtEighth")]
        public string ExtEighth{ get; set; }

        /// <summary>
        /// Custom parameter 9.
        /// </summary>
        [JsonProperty("ExtNinth")]
        public string ExtNinth{ get; set; }

        /// <summary>
        /// Custom parameter 10.
        /// </summary>
        [JsonProperty("ExtTenth")]
        public string ExtTenth{ get; set; }

        /// <summary>
        /// Time period.
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "VersionNum", this.VersionNum);
            this.SetParamSimple(map, prefix + "ExtFirst", this.ExtFirst);
            this.SetParamSimple(map, prefix + "ExtSecond", this.ExtSecond);
            this.SetParamSimple(map, prefix + "ExtThird", this.ExtThird);
            this.SetParamSimple(map, prefix + "IsAbroad", this.IsAbroad);
            this.SetParamSimple(map, prefix + "Browser", this.Browser);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "CostType", this.CostType);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "NetStatus", this.NetStatus);
            this.SetParamSimple(map, prefix + "WebVitals", this.WebVitals);
            this.SetParamSimple(map, prefix + "ExtFourth", this.ExtFourth);
            this.SetParamSimple(map, prefix + "ExtFifth", this.ExtFifth);
            this.SetParamSimple(map, prefix + "ExtSixth", this.ExtSixth);
            this.SetParamSimple(map, prefix + "ExtSeventh", this.ExtSeventh);
            this.SetParamSimple(map, prefix + "ExtEighth", this.ExtEighth);
            this.SetParamSimple(map, prefix + "ExtNinth", this.ExtNinth);
            this.SetParamSimple(map, prefix + "ExtTenth", this.ExtTenth);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
        }
    }
}

