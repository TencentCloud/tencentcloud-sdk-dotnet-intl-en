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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeGeneralInvoiceResponse : AbstractModel
    {
        
        /// <summary>
        /// Mixed invoice/ticket recognition result. Please click the link on the left for details.
        /// </summary>
        [JsonProperty("MixedInvoiceItems")]
        public InvoiceItem[] MixedInvoiceItems{ get; set; }

        /// <summary>
        /// Total number of pages in the PDF file.
        /// </summary>
        [JsonProperty("TotalPDFCount")]
        public long? TotalPDFCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "MixedInvoiceItems.", this.MixedInvoiceItems);
            this.SetParamSimple(map, prefix + "TotalPDFCount", this.TotalPDFCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

