import Swal from "sweetalert2";

class Alert {
  error(title: string, messages: string[] | string) {
    if (messages instanceof Array)
      messages = this.arrayStringToHtmlUnorderedList(messages);

    Swal.fire({
      title: title,
      html: messages,
      showCloseButton: true,
      icon: "error",
    });
  }

  arrayStringToHtmlUnorderedList(errorList: string[]) {
    var html = "<ul>";
    errorList.forEach(function (error) {
      html += `<li>- ${error}</li>`;
    });
    html += "</ul>";
    return html;
  }
}

export default new Alert();
