
@Code
    ViewData("Title") = "INPUT_YOR_4"
End Code

<div class="ic">
    <div style="font-family:'Taviraj';width:100%">
        <div>
            <p style="text-align: right;">แบบ ย.4</p>
            <p style="text-align: right;">FORM MA-4</p>
        </div>

        <h1 style="text-align: center;"> คำขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยา</h1>
        <div>
            <h1 style="text-align: center;"> เกี่ยวกับผู้รับอนุญาตและสถานที่ผลิตในต่างประเทศ</h1>
        </div>
        <hr />
        <div>
            <label>
                เขียนที่ :
            </label>
            <input name="v" type="text" style="width:20%" />
        </div>
        <div>
            <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                           input-aria-describedby="datepicker-description"
                           input-aria-labelledby="datepicker-header ">

            </md-datepicker>
        </div>
        <h3 style="text-align: start;">
            ขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยาทุกตำรับที่ข้าพเจ้าได้ขึ้นทะเบียนไว้ต่อสำนักงานคณะกรรมการอาหารและยา
            ในส่วนที่เกี่ยวกับผู้รับอนุญาตโดยการสลักหลังใบสำคัญการขึ้นทะเบียตำรับยา
        </h3>
        <div>
            <input type="checkbox" /> (๑) การเปลี่ยนแปลงชื่อตัวหรือชื่อสกลของผู้รับอนุญาต
        </div>
        <div>
            <input type="checkbox" /> (๒) การย้ายสถานที่ผลิตหรือสถานที่นำหรือสั่งเข้ามาในราชอาณาจักร หรือสถานที่ผลิตในต่างประเทศ
        </div>
        <div>
            <input type="checkbox" /> (๓) การเปลี่ยนแปลง แก้ไข หรือเพิ่มเติมชื่อสถานที่ผลิต ชื่อสถานที่นำหรือสั่งเข้ามาในราชอาณาจักร หรือชื่อสถานที่ผลิตในต่างประเทศ
        </div>
        <div>
            <input type="checkbox" /> (๔) อื่นๆ :<input type="text" size="100" />
        </div>
        <label>
            ปรากกฎรายละเอียดดังนี้คือ:
        </label>
        <div>
            <input name="v" type="text" style="width:100%" />
        </div>
        <label>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</label>
        <div>
            <label>(๑) สำเนาใบอนุญาต</label>
        </div>
        <div>
            <label>(๒) ใบสำคัญการขึ้นทะเบียนตำรับยาหรือใบแทน</label>
        </div>
        <div>
            <label>(๓) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอแก้ไขหรือเปลี่ยนแลง</label>
        </div>
    </div>
</div>
