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

    public class InvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// The recognition result.
        /// `OK`: Recognition is successful.
        /// `FailedOperation.UnsupportedInvoice`: Recognition is not supported.
        /// `FailedOperation.UnKnowError`: Recognition failed.
        /// For the information about other error codes, see the OCR API description for each invoice/ticket.
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// The type of invoice/ticket to which the recognized image belongs.
        /// -1: Unknown
        /// 0: Taxi receipt
        /// 1: Quota invoice
        /// 2: Train ticket
        /// 3: VAT invoice
        /// 5: Itinerary/Receipt of e-ticket for air transportation
        /// 8: General machine-printed invoice
        /// 9: Bus ticket
        /// 10: Ship ticket
        /// 11: VAT invoice (roll)
        /// 12: Car sales invoice
        /// 13: Toll receipt
        /// 15: Non-tax revenue invoice
        /// 16: Fully digitalized electronic invoice
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// The coordinates of the four vertices of the rotated image.
        /// </summary>
        [JsonProperty("Polygon")]
        public Polygon Polygon{ get; set; }

        /// <summary>
        /// The rotation angle of the recognized image in the image with multiple types of invoices/tickets.
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// The recognized content.
        /// </summary>
        [JsonProperty("SingleInvoiceInfos")]
        public SingleInvoiceItem SingleInvoiceInfos{ get; set; }

        /// <summary>
        /// The number of the page on which the recognized invoice is in the image or PDF file, starting from 1 by default.
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// The detailed invoice type. See the description of `SubType`.
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// The invoice description. See the description of `TypeDescription`.
        /// </summary>
        [JsonProperty("TypeDescription")]
        public string TypeDescription{ get; set; }

        /// <summary>
        /// The image file after cropping, encoded in Base64. This is returned if `EnableCutImage` is set to `true`.
        /// </summary>
        [JsonProperty("CutImage")]
        public string CutImage{ get; set; }

        /// <summary>
        /// The description of the detailed invoice type. See the description of `SubType`.
        /// </summary>
        [JsonProperty("SubTypeDescription")]
        public string SubTypeDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamObj(map, prefix + "SingleInvoiceInfos.", this.SingleInvoiceInfos);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "TypeDescription", this.TypeDescription);
            this.SetParamSimple(map, prefix + "CutImage", this.CutImage);
            this.SetParamSimple(map, prefix + "SubTypeDescription", this.SubTypeDescription);
        }
    }
}

